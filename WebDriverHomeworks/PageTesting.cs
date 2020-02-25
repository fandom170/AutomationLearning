using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverHomeworks
{
    [TestFixture]
    public class PageTesting
    {
        IWebDriver driver;
        PageGismeteo pageGismeteo;

        [SetUp]
        public void StartBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver("C:\\Automation\\Driver");
            driver.Url = _helpers.URLGISMETEO;
            pageGismeteo = new PageGismeteo();
            PageFactory.InitElements(driver, pageGismeteo);
        }

        [Test, Order(0)]
        public void CheckTitle() 
        {
            Assert.That(pageGismeteo.PageTitle.Displayed);
        }
        
        [Test(Description = "Get all Div from the page")]
        public void GetAllDivs() 
        {
            foreach (IWebElement webElem in pageGismeteo.AllDiv) 
            { 
                //DO NOTHING
            }
            //Console.WriteLine(pageGismeteo);
        }

        //find all div with h2


        //


        [TearDown]
        public void ClosePage() 
        {
            driver.Close();
        }
    }
}
