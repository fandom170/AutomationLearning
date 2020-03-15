using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    public static class WizzAirSelectFlightsLocators
    {
        public static string PageTitle = ".//div[@id = 'booking-flow-step-select-flight']/h2"; //xpath

        public static string FlightDate = ".flight-select__flight-info__day";
        public static string DestinationPoints = ".//div[@id = 'outbound-fare-selector']/div/address";

        public static string PriceTile = ".//div[@class = 'flight-select__flight-date-picker__day__info']"; //it will be seven items
        public static string dateInTile = ".//div[@class = 'flight-select__flight-date-picker__day__info']/time";
        public static string PriceInTile = ".//div[@class = 'flight-select__flight-date-picker__day__price']";

        public static string ButtonAcceptFlight = ".//div[contains (@class, 'fare-type-button__title fare-type-button__title--active')]"; //xpath

        public static string ButtonMiddlePlanSelect = ".//div[@class = 'flight-select__flight__fare-buttons']/div[1]/div[1]"; //xpath

        public static string FlightBack;

        public static string ButtonContinue = "flight-select-continue-button"; //ID

        public static string LabelClosestDate = ".//div[@class = flight-select__flight-date-picker__day__info]/time";

        //After price selections
        public static string ChangedPageTitle = ".//div[@id = 'booking-flow-step-select-flight']/h2";
    }
}
