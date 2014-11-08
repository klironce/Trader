using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using trader.Modules;
using trader.Core.DataType;
using trader.Net;

namespace trader.Core
{
    public class init
    {

        public dataSystem DS;
        public traderLogic TL;
        public c_Net Net;

        public init()
        {
            DS = new dataSystem();
            TL = new traderLogic();
            Net = new c_Net();
            Net.LoadTableFromType(EnumTypes.SiteType.Vircurex);
        }
    }
}
