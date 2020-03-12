using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace WebDriverHomeworks.Base
{
    public class TestBase : Base.InitPages
    {
        public IWebDriver driver;
        public WebDriverWait Wait;

        [OneTimeSetUp]
        [Obsolete]
        public void SetUp()
        {
             

            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);

            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //Wait = new WebDriverWait(driver, waitForElement);
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);

            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLWIZZ;

            MainPage = new Pages.WizzAirMain(driver);
            SelectFlights = new Pages.WizzAirSelectFlights(driver);

        }

        [OneTimeTearDown]
        public void TearDown () 
        {
            Thread.Sleep(10000);/////////////////////////////////////
            driver.Close();
            driver.Quit();
        }

        public void SwitchToNewTab() 
        {
            var newWindow = driver.WindowHandles[1]; 
            Assert.IsTrue(!string.IsNullOrEmpty(newWindow)); // tab was opened
            StringAssert.Contains(_helpers.URLWIZZ, driver.SwitchTo().Window(newWindow).Url, "URL mismatching"); // url is OK  
        }

        public void ReturnToParentTab() 
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void closeTab(int tabNo = 0) 
        {
            //closed first tab by default
            driver.SwitchTo().Window(driver.WindowHandles[tabNo]).Close();
        }
    }
}
