using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Pages
{
    using MorfLearning.Common;
    using OpenQA.Selenium;

    using Selenium;

    class HomePage
    {
        private IWebDriver driver = WebDriverProvider.GetFirefoxDriver;

        public PlayPage ClickOnPlayButton()
        {
            driver.FindElement(By.CssSelector("a.btn-primary")).Click();
            return new PlayPage();
        }
    }
}
