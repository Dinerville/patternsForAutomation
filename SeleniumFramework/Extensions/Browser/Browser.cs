using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SeleniumFramework.Extensions
{
    class Browser
    {
        private static IWebDriver instance;

        private Browser() { }

        public static IWebDriver Driver
        {
            get
            {
                if (instance == null)
                {
                    instance = new BrowserFactory().GetDriver(ConfigurationManager.AppSettings["browser"]);
                }
                return instance;
            }
        }
    }
}
