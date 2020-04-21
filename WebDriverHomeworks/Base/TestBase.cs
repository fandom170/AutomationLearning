using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using log4net;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace WebDriverHomeworks.Base
{
    

    [Obsolete]
    public class TestBase : Base.InitPages
    {
        public WebDriverWait Wait;
        public WebDriverWait WaitMin;
        public ILog LogTest;


        [OneTimeSetUp]
        [Obsolete]
        public void SetUp()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);
            Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 180));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);
            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLWIZZ;

            LogTest = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            initPages(driver);
        }

        [OneTimeTearDown]
        public void TearDown () 
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }

        
        public void closeTab(int tabNo = 0) 
        {
            //closed first tab by default
            driver.SwitchTo().Window(driver.WindowHandles[tabNo]).Close();
        }

        public void ScrollToElement(IWebElement element) 
        {
            ScrollToView(element);
        }

        public void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript(js);
        }

        public void ScrollToView(IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }

        public void PopulateField(IWebElement element, String data) 
        {
            element.Clear();
            element.SendKeys(data);

        }

    }
}
