using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader.Core.DataType
{
    public class EnumTypes
    {

        public enum ColumnType
        {
            header = 2,
            body = 4
        };

        public enum SiteType
        {
            Cryptsy = 0,
            Vircurex = 1,
            Bitfinex = 2
        };

    }
}
