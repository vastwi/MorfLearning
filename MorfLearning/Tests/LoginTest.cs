using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace MorfLearning.Tests
{
    using MorfLearning.Pages;

    public class LoginTest
    {
        [Test]
        public void LoginWithAdminAndCheckForCourses()
        {
            new HomePage()
                .ClickOnPlayButton()
                .GiveValidUserNameAndPassword()
                .ClickOnLoginButton()
                .ClickOnCourses()
                .ClickOnTILARESPA()
                .ClickOnContinue();
        }
    }
}
