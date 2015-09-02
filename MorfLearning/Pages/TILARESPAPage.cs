using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Pages
{
    using MorfLearning.Common;
    using OpenQA.Selenium;

    class TILARESPAPage
    {
        private IWebDriver driver = WebDriverProvider.GetFirefoxDriver;

        public TILARESPAPage ClickOnContinue()
        {
            WebDriverFunctions.WaitForElementToBeVisible("button.continueButton");
            driver.FindElement(By.CssSelector("button.continueButton")).Click();
            return this;
        }
    }
}
