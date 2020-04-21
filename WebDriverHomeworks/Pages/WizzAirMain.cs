using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Pages
{
    public class WizzAirMain
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirMain(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement LinkRoute() { return driver.FindElement(Locators.WizzAirMainPageLocators.RouteSelection); }
        public IWebElement FlightTo() { return driver.FindElement(Locators.WizzAirMainPageLocators.FlightTo); }
        public IWebElement SearchFlight() { return driver.FindElement(Locators.WizzAirMainPageLocators.FindButton); }
        public IWebElement FieldFrom() { return driver.FindElement(Locators.WizzAirMainPageLocators.FlightFrom); }
        
    }
}
