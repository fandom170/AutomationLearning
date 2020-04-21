using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    static class WizzAirMainPageLocators
    {
        public static By FlightFrom =           By.Id("search-departure-station");
        public static By FlightTo =             By.Id("search-arrival-station");
        public static By RouteSelection =       By.CssSelector(".locations-container__location__name");
        public static By FindButton =           By.XPath(".//div[contains(@class,'flight-search__panel__fieldset')]/button");
    }
}
