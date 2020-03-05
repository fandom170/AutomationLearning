using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    public static class WizzAirSelectFlightsLocators
    {
        public static string FlightDate = ".flight-select__flight-info__day";
        public static string PointFrom;
        public static string PointTo;

        public static string PriceTile = ".//div[@class = 'flight-select__flight-date-picker__day__info']"; //it will be seven items
        public static string dateInTile = ".//div[@class = 'flight-select__flight-date-picker__day__info']/time";
        public static string PriceInTile = ".//div[@class = 'flight-select__flight-date-picker__day__price']";

        public static string ButtonAcceptFlight = ".fare-button__background"; //css

        public static string ButtonMiddlePlanSelect = "fare3841-middle"; //ID

        public static string FlightBack;

        public static string ButtonContinue = "flight-select-continue-button"; //ID

    }
}
