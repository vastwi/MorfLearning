using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Tests
{
    using MorfLearning.Common;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    [SetUpFixture]
    class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var driver = WebDriverProvider.GetFirefoxDriver;
            driver.Navigate().GoToUrl("http://pilot.morflearning.com");
        }

        [TearDown]
        public void Teardown()
        {
            WebDriverProvider.quit();
        }
    }
}
