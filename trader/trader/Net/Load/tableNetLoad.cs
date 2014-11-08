using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;

namespace trader.Net.Load
{
    public class tableNetLoad
    {

        public string Table1 = "";
        public string Table2 = "";
        public static WebClient wClient;
        public static Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
        HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        HtmlNodeCollection listsNode;

        public void LoadTableData(trader.Core.DataType.EnumTypes.SiteType Type,string url,string table1XPath,string table2XPath)
        {
            switch (Type)
            {
                case Core.DataType.EnumTypes.SiteType.Cryptsy:
                    Cryptsy(url, table1XPath);
                    Cryptsy(url, table2XPath);
                    break;
                case Core.DataType.EnumTypes.SiteType.Bitfinex:
                    Bitfinex(url, table1XPath);
                    Bitfinex(url, table2XPath);
                    break;
                case Core.DataType.EnumTypes.SiteType.Vircurex:
                    Vircurex(url, table1XPath);
                    Vircurex(url, table2XPath);
                    break;
            }
        }

        private string Cryptsy(string url, string tableXPath)
        {
           //var listsNode1 = doc.DocumentNode.SelectNodes(tableXPath);
            return null;
        }
        private string Bitfinex(string url, string tableXPath)
        {
            //doc.LoadHtml(wClient.DownloadString(url));
            return null;
        }
        private string Vircurex(string url, string tableXPath)
        {
            //this.Table1 = wClient.DownloadString(url);
            return null;
        }

    }
}
