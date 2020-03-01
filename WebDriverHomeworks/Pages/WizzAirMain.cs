using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Pages
{
    class WizzAirMain
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirMain(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement FieldFrom() 
        {
            return driver.FindElement(By.Id(Locators.WizzAirMainPageLocators.FlightFrom));
        }

        public IWebElement FieldTo() 
        {
            return driver.FindElement(By.Id(Locators.WizzAirMainPageLocators.FlightTo));
        }

        public IWebElement SearchFlight() 
        {
            return driver.FindElement(By.XPath(Locators.WizzAirMainPageLocators.FindButton));
        }
    }
}
