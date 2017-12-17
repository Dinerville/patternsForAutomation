using OpenQA.Selenium;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Extensions
{
    public class MathodOfDiscoveryFactory
    {
        public By GetBy(string locator, MethodOfDiscovery methodOfDiscovery) {
            switch (methodOfDiscovery) {
                case MethodOfDiscovery.XPath:
                    return By.XPath(locator);
                case MethodOfDiscovery.CSSSelector:
                    return By.CssSelector(locator);
                default:
                    throw new Exception($"Method of dicovery {methodOfDiscovery} is not present");
            }
        }
        public enum MethodOfDiscovery {
            XPath,
            CSSSelector
        }
    }
}
