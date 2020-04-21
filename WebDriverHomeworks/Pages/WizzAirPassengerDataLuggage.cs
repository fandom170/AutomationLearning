using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Pages
{
    public class WizzAirPassengerDataLuggage
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirPassengerDataLuggage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement FieldFirstName() { return driver.FindElement(Locators.WizzAirPassengerLuggageLocators.FieldFirstName); }
        public IWebElement FieldLastName() { return driver.FindElement(Locators.WizzAirPassengerLuggageLocators.FieldLastName); }
        public IWebElement ButtonPassengerGender() { return driver.FindElement(Locators.WizzAirPassengerLuggageLocators.FieldGenderMale); }
        public IWebElement ButtonContinue() { return driver.FindElement(Locators.WizzAirPassengerLuggageLocators.ButtonContinue); }
        public IWebElement PageTitle() { return driver.FindElement(Locators.WizzAirPassengerLuggageLocators.LabelPageTitle); }
    }
}
