using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverHomeworks
{
    class PageGismeteo
    {
        private IWebDriver driver;

        By pageTitle = By.Id("Page-1");


        public IWebElement PageTitle() 
        {
            return driver.FindElement(By.XPath(""));
        }
        
        //[FindsBy(How = How.Id, Using = "Page-1")]
        //public WebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div")]
        public List <IWebElement> AllDiv { get; set; }

    }
}
