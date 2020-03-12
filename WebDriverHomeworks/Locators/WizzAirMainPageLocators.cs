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
        public static string FlightFrom =           "search-departure-station"; //id
        public static string FlightTo =             "search-arrival-station"; //Id
        public static string RouteSelection =       ".locations-container__location__name"; //css
        //public static string FlightFromSelection =  ".//div[@class = 'locations-container__group']//*[contains, text('"+ _helpers.FlightFromFull + "')]";
        //public static string FlightToSelection =    ".//div[@class = 'locations-container__group']//*[contains, text('" + _helpers.FlightToFull + "')]";

        public static string DatePicker; //will be added if needed

        public static string FindButton = ".//div[contains(@class,'flight-search__panel__fieldset')]/button"; //xpath
    }
}
