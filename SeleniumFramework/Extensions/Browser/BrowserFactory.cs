using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    class BrowserFactory
    {
        public IWebDriver GetDriver(string browserName) {
            if (bool.Parse(ConfigurationManager.AppSettings["useGrid"]))
            {
                switch (browserName.ToLower().Trim())
                {
                    case "chrome":
                        return new ChromeDriverBuilder().UseGrid(true).BuildDriver();
                    case "firefox":
                        return new FirefoxDriverBuilder().UseGrid(true).BuildDriver();
                    default:
                        throw new Exception($"{browserName} -  The name of the browser is incorrect. Possible variants are:\nchrome");
                }
            }
            else {
                switch (browserName.ToLower().Trim())
                {
                    case "chrome":
                        return new ChromeDriverBuilder().BuildDriver();
                    case "firefox":
                        return new FirefoxDriverBuilder().BuildDriver();
                    default:
                        throw new Exception($"{browserName} -  The name of the browser is incorrect. Possible variants are:\nchrome");
                }
            }
           
        }
    }
}
