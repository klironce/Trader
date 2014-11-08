using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using trader.Net.Load;
using trader.Core.DataType;

namespace trader.Net
{
    public class c_Net
    {
        tableNetLoad tNetLoad = new tableNetLoad();
        string XPath_cryptsy_sell = "//*[@id='sellorderlist']/tbody";
        string XPath_cryptsy_buy = "//*[@id='buyorderlist']/tbody";
        string cryptsy_url = "https://www.cryptsy.com/markets/view/LTC_BTC";

        string XPath_vircurex_sell = "//*[@id='selltable']/table/tbody";
        string XPath_vircurex_buy = "//*[@id='buytable']/table/tbody";
        string vircurex_url = "https://vircurex.com/welcome/index?alt=btc&base=ltc&locale=en";

        string XPath_bitfinex_bids = "//*[@id='bidsTableBody']";
        string XPath_bitfinex_asks = "//*[@id='asksTableBody']";
        string bitfinex_url = "http://www.bfxdata.com/orderbooks/ltcbtc.php";

        public void LoadTableFromType(EnumTypes.SiteType Type)
        {
            switch (Type)
            {
                case EnumTypes.SiteType.Cryptsy:
                    tNetLoad.LoadTableData(Type, cryptsy_url, XPath_cryptsy_sell, XPath_cryptsy_buy);
                    break;
                case EnumTypes.SiteType.Bitfinex:
                    tNetLoad.LoadTableData(Type, bitfinex_url, XPath_bitfinex_bids, XPath_bitfinex_asks);
                    break;
                case EnumTypes.SiteType.Vircurex:
                    tNetLoad.LoadTableData(Type, vircurex_url, XPath_vircurex_sell, XPath_vircurex_buy);
                    break;
            }
        }


    }
}
