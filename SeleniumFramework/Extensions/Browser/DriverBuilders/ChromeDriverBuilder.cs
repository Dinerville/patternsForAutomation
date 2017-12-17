using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumFramework
{
    class ChromeDriverBuilder : IBrowserBuilder
    {
        private bool _useGrid = false;
        public IWebDriver BuildDriver()
        {
            if (_useGrid)
            {
                throw new NotImplementedException();
            }
            else
            {
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
