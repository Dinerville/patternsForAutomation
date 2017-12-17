using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumFramework.Extensions.MathodOfDiscoveryFactory;

namespace SeleniumFramework.Base
{
    public class BaseForm
    {
        private static By _titleLocator;
        public BaseForm(string titleLocator, string navigationUrl, MethodOfDiscovery methodOfDiscovery = MethodOfDiscovery.XPath, bool navigate = false) {
            _titleLocator = new MathodOfDiscoveryFactory().GetBy(titleLocator,methodOfDiscovery);
            if (navigate) {
                Navigation.Navigate(navigationUrl);
            }
            AssertIsOpen();
        }
        public BaseForm(string titleLocator, string domain,string navigationUrl, MethodOfDiscovery methodOfDiscovery = MethodOfDiscovery.XPath, bool navigate = false)
        {
            _titleLocator = new MathodOfDiscoveryFactory().GetBy(titleLocator, methodOfDiscovery);
            if (navigate)
            {
                Navigation.Navigate(navigationUrl,domain);
            }
            AssertIsOpen();
        }

        public void AssertIsOpen() {
            throw new NotImplementedException();
        }
    }
}
