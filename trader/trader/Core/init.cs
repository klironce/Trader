﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using trader.Modules;
using trader.Core.DataType;

namespace trader.Core
{
    public class init
    {

        public dataSystem DS;
        public traderLogic TL;

        public init()
        {
            DS = new dataSystem();
            TL = new traderLogic();
        }
    }
}
