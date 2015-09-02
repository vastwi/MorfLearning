using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Pages
{
    using MorfLearning.Common;
    using OpenQA.Selenium;

    class ProfilePage
    {
        private IWebDriver driver = WebDriverProvider.GetFirefoxDriver;

        public CoursesPage ClickOnCourses()
        {
            WebDriverFunctions.WaitForElementWithXpathVisible("//div[@id='content']//label[text()='Courses']");            
            driver.FindElement(By.XPath("//div[@id='content']//label[text()='Courses']")).Click();
            return new CoursesPage();
        }
    }
}
