using Dapper;
using SuperMarket.Classes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SuperMarket.Classes.DataAccess
{
    internal class Orders
    {
        private static readonly int MaxRows = GlobalVars.MaxQueryRows;
        internal static List<OrderModel> GetOrderParameter(string Parameter, string Condition)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    var output = cnn.Query<OrderModel>($"SELECT TOP {MaxRows} * FROM Orders WHERE {Parameter} = N'{Condition}'", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting order with param = {Parameter} & condition = {Condition} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Orders", Logger.ERROR);
            }
            return new List<OrderModel>();
        }

        internal static void AddOrder(OrderModel order)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    cnn.Execute($"INSERT INTO Orders (InvoiceDate, InvoiceId, CustomerId, CustomerName, " +
                        $"ContactNumber, Address, GrandTotal, CreatedByUserId, CreatedByUserFullName) VALUES (@InvoiceDate, @InvoiceId, @CustomerId, @CustomerName, " +
                        $"@ContactNumber, @Address, @GrandTotal, @CreatedByUserId, @CreatedByUserFullName)", order);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while adding order for invoice id = {order.InvoiceId} & error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Orders", Logger.ERROR);
            }
        }

        internal static List<OrderModel> GetAllOrders(bool LimitRows)
        {
            try
            {
                using (IDbConnection cnn = new SqlConnection(GlobalVars.LoadConnectionString()))
                {
                    if (LimitRows)
                    {
                        var output = cnn.Query<OrderModel>($"SELECT TOP {MaxRows} * FROM Orders", new DynamicParameters());
                        return output.ToList();
                    }
                    else
                    {
                        var output = cnn.Query<OrderModel>($"SELECT * FROM Orders", new DynamicParameters());
                        return output.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.Log($"while getting all orders error: {ex.Message}",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "Orders", Logger.ERROR);
            }
            return new List<OrderModel>();
        }
    }
}