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
    public class WizzAirSelectFlights
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirSelectFlights(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement ButtonShowPrices => driver.FindElement(By.XPath(WizzAirSelectFlightsLocators.ButtonAcceptFlight));
        public IWebElement ButtonMiddlePrice => driver.FindElement(By.XPath(WizzAirSelectFlightsLocators.ButtonMiddlePlanSelect));
        public IWebElement PageTitle => driver.FindElement(By.XPath(Locators.WizzAirSelectFlightsLocators.PageTitle));
        public IWebElement ButtonContinue => driver.FindElement(By.Id(Locators.WizzAirSelectFlightsLocators.ButtonContinue));

        public IWebElement ChangedPageTitle => driver.FindElement(By.XPath(Locators.WizzAirSelectFlightsLocators.ChangedPageTitle));
        public IWebElement DestinationPoints => driver.FindElement(By.XPath(Locators.WizzAirSelectFlightsLocators.DestinationPoints));
    }
}
