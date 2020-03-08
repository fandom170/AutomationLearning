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
        public Pages.WizzAirSelectFlights SelectFlights; 

        [OneTimeSetUp]
        [Obsolete]
        public void SetUp()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);
            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLWIZZ;

            MainPage = new Pages.WizzAirMain(driver);
            SelectFlights = new Pages.WizzAirSelectFlights(driver);

        }

        

        [OneTimeTearDown]
        public void TearDown () 
        {
            driver.Close();
            driver.Quit();
        }

        public void SwitchToNewTab() 
        {
            var popup = driver.WindowHandles[1]; // handler for the new tab
            Assert.IsTrue(!string.IsNullOrEmpty(popup)); // tab was opened
            //Assert.AreEqual(driver.SwitchTo().Window(popup).Url, "http://blah"); // url is OK  
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close(); // close the tab
            
        }

        public void ReturnToParentTab() 
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
    }
}
