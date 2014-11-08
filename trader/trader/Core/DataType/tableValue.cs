using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader.Core.DataType
{
    public class tableValue
    {
        string value;
        public void Set<T>(T tr){
            value = Convert.ToString(tr);
        }
        public string Get()
        {
            return value;
        }
    }
}
