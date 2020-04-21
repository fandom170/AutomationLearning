using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public IWebElement ButtonShowPrices() { return driver.FindElement(WizzAirSelectFlightsLocators.ButtonShowPrices); }
        public IWebElement ButtonMiddlePrice() { return driver.FindElement(WizzAirSelectFlightsLocators.ButtonMiddlePlanSelect); }
        public IWebElement PageTitle() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.PageTitle); }
        public IWebElement ButtonContinue() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.ButtonContinue); }
        public IWebElement ChangedPageTitle() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.ChangedPageTitle); }
        public IWebElement DestinationPoints() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.DestinationPoints); }
        public IWebElement DivSelectedFlights() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.DivSelctedFlights); }
        public IWebElement ReturnFlightLink() { return driver.FindElement(Locators.WizzAirSelectFlightsLocators.ReturnFlightsLink); }
        
        public IWebElement ReturnFlightBlock() 
        {
            try
            {
                return driver.FindElement(Locators.WizzAirSelectFlightsLocators.ReturnFlightBlock);
            }
            catch (NoSuchElementException) 
            {
                return null;
            }
        }

        public void ClosePopup() 
        {
            Thread.Sleep(1000);
            try
            {
                driver.FindElement(Locators.WizzAirSelectFlightsLocators.ButtonClosePopup).Click();
            }
            catch (NoSuchElementException) { }
        }

        public List<IWebElement> PricesList() 
        {
            return driver.FindElements(Locators.WizzAirSelectFlightsLocators.Prices).ToList();
        }
    }
}
