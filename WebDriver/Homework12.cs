using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Chrome.ChromeDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTesting
{
    class Homework12
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }
        
        [Test]
        public void OpenPage() 
        {
            driver.Url = "wizzair.com";
        }


        /*
        [TearDown]
        public void CloseBrowser() 
        {
            driver.Close();
        }
        */

    }
}
