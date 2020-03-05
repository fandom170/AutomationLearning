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
        public static string FlightFrom =   "search-departure-station"; //id
        public static string FlightTo =     "search-arrival-station"; //Id

        public static string DatePicker; //will be added if needed

        public static string FindButton = ".//div[contains(@class,'flight-search__panel__fieldset')]/button"; //xpath
    }
}
