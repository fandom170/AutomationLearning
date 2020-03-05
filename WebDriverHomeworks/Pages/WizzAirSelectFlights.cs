using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverHomeworks.Locators;

namespace WebDriverHomeworks.Pages
{
    class WizzAirSelectFlights
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirSelectFlights(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        IWebElement ButtonShowPrices() => driver.FindElement(By.CssSelector(WizzAirSelectFlightsLocators.ButtonAcceptFlight));

        IWebElement ButtonMiddlePrice() => driver.FindElement(By.Id(WizzAirSelectFlightsLocators.ButtonMiddlePlanSelect)); 
    }
}
