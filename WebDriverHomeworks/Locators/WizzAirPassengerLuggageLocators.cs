using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    class WizzAirPassengerLuggageLocators
    {
        public static By FieldFirstName         = By.Id("passenger-first-name-0"); //ID
        public static By FieldLastName          = By.Id("passenger-last-name-0"); //ID
        public static By FieldGenderMale        = By.CssSelector("input#passenger-gender-0-male");
        public static By ButtonContinue         = By.Id("passengers-continue-btn"); //ID
        public static By LabelPageTitle         = By.XPath(".//article[@id = 'booking-flow-step-passengers']/div/form/h2"); //xpath
    }
}
