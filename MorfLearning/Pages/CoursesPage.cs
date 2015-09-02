using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Pages
{
    using MorfLearning.Common;
    using OpenQA.Selenium;

    class CoursesPage
    {
        private IWebDriver driver = WebDriverProvider.GetFirefoxDriver;

        public TILARESPAPage ClickOnTILARESPA()
        {
            WebDriverFunctions.WaitForElementWithXpathVisible("//label[text()='TILA RESPA Integrated Disclosure']");
            driver.FindElement(By.XPath("//label[text()='TILA RESPA Integrated Disclosure']")).Click();
            return new TILARESPAPage();
        }
    }
}
