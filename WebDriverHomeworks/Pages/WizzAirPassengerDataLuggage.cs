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

        public IWebElement FieldFirstName => driver.FindElement(By.Id(Locators.WizzAirPassengerLuggageLocators.FieldFirstName));
        public IWebElement FieldLastName => driver.FindElement(By.Id(Locators.WizzAirPassengerLuggageLocators.FieldLastName));
        public IWebElement ButtonPassengerGender => driver.FindElement(By.Id(Locators.WizzAirPassengerLuggageLocators.FieldGenderMale));
        public IWebElement Buttoncontinue => driver.FindElement(By.Id(Locators.WizzAirPassengerLuggageLocators.ButtonContinue));





    }
}
