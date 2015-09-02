using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Pages
{
    using MorfLearning.Common;
    using OpenQA.Selenium;

    class PlayPage
    {
        private IWebDriver driver = WebDriverProvider.GetFirefoxDriver;

        public PlayPage GiveValidUserNameAndPassword()
        {
            WebDriverFunctions.WaitForElementToBeVisible("input[placeholder='Username']");
            driver.FindElement(By.CssSelector("input[placeholder='Username']")).SendKeys("administrator");
            driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("administrator");
            return this;
        }

        public ProfilePage ClickOnLoginButton()
        {
            driver.FindElement(By.XPath("id('content')//button")).Click();
            return new ProfilePage();
        } 
    }
}
