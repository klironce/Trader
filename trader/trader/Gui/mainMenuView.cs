using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using trader.Core;

namespace trader
{
    public partial class mainMenuView : Form
    {

        public init _init;

        public mainMenuView(ref init _initialize)
        {
            this._init = _initialize;
            InitializeComponent();
        }
    }
}
