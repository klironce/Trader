using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader.Core.DataType
{
    public class tableColumn
    {
        public EnumTypes.ColumnType Type;
        public tableValue value = new tableValue();

        public tableColumn()
        {
            value = new tableValue();
        }
    }
}
