using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes
{
    class GlobalVars
    {
        private static int maxQueryRows = 100;
        public static int MaxQueryRows
        {
            get { return maxQueryRows; }
            set { }
        }
    }
}
