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

        public IWebElement FieldFrom => driver.FindElement(By.Id(Locators.WizzAirMainPageLocators.FlightFrom));
        public IWebElement LinkRoute => driver.FindElement(By.CssSelector(Locators.WizzAirMainPageLocators.RouteSelection));
        public IWebElement FieldTo => driver.FindElement(By.Id(Locators.WizzAirMainPageLocators.FlightTo));
        public IWebElement SearchFlight => driver.FindElement(By.XPath(Locators.WizzAirMainPageLocators.FindButton));
        
    }
}
