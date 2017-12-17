using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Extensions;
using System.Configuration;
using static SeleniumFramework.Extensions.MathodOfDiscoveryFactory;

namespace SeleniumFramework.Base
{
    public class BaseElement
    {
        public By _locator;
        public TimeSpan _longDurationSeconds = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["implicitWaitSeconds"]));
        public TimeSpan _shortDurationSeconds = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["shortDurationSeconds"]));
        public BaseElement(string titleLocator, MethodOfDiscovery methodOfDiscovery = MethodOfDiscovery.XPath) {
            _locator = new MathodOfDiscoveryFactory().GetBy(titleLocator, methodOfDiscovery);
        }
        public IWebElement GetElement() {
            var element = Browser.Driver.FindElement(_locator);
            return element;
        }
        public IWebElement WaitForElementExists(TimeSpan timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, timeToWait);
            return wait.Until(ExpectedConditions.ElementExists(_locator));
        }
        
        public IWebElement WaitForElementIsVisible(TimeSpan timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, timeToWait);
            return wait.Until(ExpectedConditions.ElementIsVisible(_locator));
        }
        public bool IsExists() {
           return WaitForElementExists(_shortDurationSeconds)!=null;
        }
        public bool IsExistsLongWait()
        {
            return WaitForElementExists(_longDurationSeconds) != null;
        }
    }
}
