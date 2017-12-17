using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public interface IBrowserBuilder
    {
         IWebDriver BuildDriver();
        IBrowserBuilder UseGrid(bool useGrid);
    }
}
