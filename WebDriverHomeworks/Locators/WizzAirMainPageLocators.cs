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
        public static string FlightFrom =   "search-departure-station";
        public static string FlightTo =     "search-arrival-station";

        public static string FindButton = ".//div[contains(@class,'flight-search__panel__fieldset')]/button";




    }
}
