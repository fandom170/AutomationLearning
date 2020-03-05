using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Base
{
    class TestBase
    {
        public IWebDriver driver;
        public Pages.WizzAirMain MainPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);
            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLWIZZ;

            MainPage = new Pages.WizzAirMain(driver);

        }

        [OneTimeTearDown]
        public void TearDown () 
        {
            driver.Close();
            driver.Quit();
        }
    }
}
