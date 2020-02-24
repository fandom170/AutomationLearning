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
    public class PageTesting
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Url = _helpers.URLGISMETEO;
        }


        [Test(Description = "Get all Div from the page")]
        public void GetAllDivs() 
        {
            PageGismeteo pageGismeteo = new PageGismeteo();
            PageFactory.InitElements(driver, pageGismeteo);
            Console.WriteLine(pageGismeteo);
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
