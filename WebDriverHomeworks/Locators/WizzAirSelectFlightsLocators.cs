using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    public static class WizzAirSelectFlightsLocators
    {
        public static By PageTitle =                By.XPath(".//div[@id = 'booking-flow-step-select-flight']/h2");
        public static By FlightDate =               By.CssSelector(".flight-select__flight-info__day");
        public static By DestinationPoints =        By.XPath(".//div[@id = 'outbound-fare-selector']/div/address");
        public static By PriceTile =                By.XPath(".//div[@class = 'flight-select__flight-date-picker__day__info']"); //it will be seven items
        public static By dateInTile =               By.XPath(".//div[@class = 'flight-select__flight-date-picker__day__info']/time");
        public static By PriceInTile =              By.XPath(".//div[@class = 'flight-select__flight-date-picker__day__price']");
        public static By ButtonShowPrices =         By.CssSelector(".fare-type-button");
        public static By ButtonMiddlePlanSelect =   By.CssSelector("div.flight-select__flight__fares > div:nth-of-type(2) " +
                                                            "div:nth-of-type(2) .fare-type-button__title.fare-type-button__title--active"); //css
        public static By ButtonContinue =           By.Id("flight-select-continue-button"); //ID
        public static By LabelClosestDate =         By.XPath(".//div[@class = flight-select__flight-date-picker__day__info]/time");
        public static By Spinner =                  By.CssSelector("div.loader-combined");
        //After price selections
        public static By ChangedPageTitle =         By.XPath(".//div[@id = 'booking-flow-step-select-flight']/h2");
        public static By DivSelctedFlights =        By.Id("selected-fares"); //id

        //tab
        public static By ButtonClosePopup =         By.CssSelector("button.modal__close");

        //prices in the labels

        public static By Prices =                   By.XPath(".//div[@class = 'flight-select__flight__fares']//div[contains(@class, 'fare-type-button__title " +
                                                                    "fare-type-button__title--active')]/span");

        public static By ReturnFlightsLink =        By.CssSelector("a.flight-select__add-return-flight__search__link");
        public static By ReturnFlightBlock =        By.CssSelector("div#return-fare-selector");
    }
}
