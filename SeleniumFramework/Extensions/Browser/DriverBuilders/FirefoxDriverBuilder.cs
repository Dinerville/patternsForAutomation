using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumFramework
{
    public class FirefoxDriverBuilder : IBrowserBuilder
    {
        private bool _useGrid;
        public IWebDriver BuildDriver()
        {
            if (_useGrid) {
                throw new NotImplementedException();
            } else {
                throw new NotImplementedException();
            }
        }

        public IBrowserBuilder UseGrid(bool useGrid)
        {
            _useGrid = useGrid;
            return this;
        }
    }
}
