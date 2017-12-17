using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Extensions
{
    public static class Navigation
    {
        private static string _baseDomain = ConfigurationManager.AppSettings["baseDomain"];
        public static void Navigate(string url, string baseDomain= null) {
            Browser.Driver.Navigate().GoToUrl($"{baseDomain??_baseDomain}{url}");
        }
    }
}
