using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes.Models
{
    class LogModel
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string MethodName { get; set; }
        public string ClassName { get; set; }
        public long LoggedUserId { get; set; }
        public string LoggedUserName { get; set; }
        public string LogLevel { get; set; }
        public string LogMessage { get; set; }
    }
}
