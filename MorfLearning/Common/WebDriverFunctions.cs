using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Common
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    class WebDriverFunctions
    {
        public static void WaitForElementToBeVisible(string element)
        {
            var wait = new WebDriverWait(WebDriverProvider.GetFirefoxDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }

        public static void WaitForElementWithXpathVisible(String element)
        {
            var wait = new WebDriverWait(WebDriverProvider.GetFirefoxDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));           
        }
    }
}
