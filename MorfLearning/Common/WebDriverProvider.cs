using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorfLearning.Common
{
    using OpenQA.Selenium.Firefox;

    class WebDriverProvider
    {
        private static FirefoxDriver driver;

        public static FirefoxDriver GetFirefoxDriver
        {
            get
            {
                if (driver == null)
                {
                    Console.WriteLine("Intializing driver .....");
                    driver = new FirefoxDriver();
                }
                return driver;
            }
        }

        public static void quit()
        {
            if (driver != null)
            {
//                driver.Close();
                driver.Quit();
                driver = null;
            }
        }
    }
}
