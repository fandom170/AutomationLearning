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
    [Obsolete]
    public class TestBase : Base.InitPages
    {
        public IWebDriver driver;
        public WebDriverWait Wait;
        public WebDriverWait WaitMin;

        [OneTimeSetUp]
        [Obsolete]
        public void SetUp()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);

            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            WaitMin = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);
            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLWIZZ;

            initPages(driver);
            //MainPage = new Pages.WizzAirMain(driver);
            //SelectFlights = new Pages.WizzAirSelectFlights(driver);

        }

        [OneTimeTearDown]
        public void TearDown () 
        {
            if (driver != null)
            {
                //driver.Close();
                //driver.Quit();
            }
        }

        public void SwitchToNewTab(int i) 
        {
            var newWindow = driver.WindowHandles[i]; 
            Assert.IsTrue(!string.IsNullOrEmpty(newWindow)); // tab was opened
            StringAssert.Contains(_helpers.URLWIZZ, driver.SwitchTo().Window(newWindow).Url, "URL mismatching"); // url is OK  
            
        }

        public void SwitchToNewTab(string str) 
        {
            var newWindow = driver.WindowHandles.Contains(str);
        }

        public void ReturnToParentTab() 
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            //driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public void SwitchTo () 
        {
            driver.SwitchTo().DefaultContent();
        }

        public void closeTab(int tabNo = 0) 
        {
            //closed first tab by default
            driver.SwitchTo().Window(driver.WindowHandles[tabNo]).Close();
        }

        

        public void WaitForElement(IWebElement element) 
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromMinutes(2);
            wait.PollingInterval = TimeSpan.FromMilliseconds(2500);
        }


    }
}
