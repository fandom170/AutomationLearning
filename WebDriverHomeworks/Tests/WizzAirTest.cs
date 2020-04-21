using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverHomeworks
{
    [TestFixture]
    [Obsolete]
    class WizzAirTest : Base.TestBase
    {
        
        
        [Test, Order(1)]
        [Description("Click on Find button")]
        public void RunSearch()
        {
            /*1. Enter flight from
             2. select from side pane
             3. enter flight to
             4. select from side pane
             5. click on serch button
             6. make sure that new screen has been opened*/

            LogTest.Info("Start Message");

            Wait.Until(ExpectedConditions.ElementExists(Locators.WizzAirMainPageLocators.FlightFrom));
            Assert.That(driver.Title, Is.EqualTo(_helpers.MainPageName), "Titles have differences");
            PopulateField(MainPage.FieldFrom(), _helpers.FlightFrom);
            Wait.Until(ExpectedConditions.ElementExists(Locators.WizzAirMainPageLocators.RouteSelection));
            MainPage.LinkRoute().Click();
            PopulateField(MainPage.FlightTo(), _helpers.FlightTo);
            Wait.Until(ExpectedConditions.ElementExists(Locators.WizzAirMainPageLocators.RouteSelection));
            MainPage.LinkRoute().Click();
            MainPage.SearchFlight().Click();
        }

        [Test, Order(2)]
        [Description("Verify flight data")]
        public void VerifyData()
        {
            /*1. Get selected date/make sure that at least one tile is selectable
             * 2. Check From and To labels
             * 2. Make sure that reverce flight is not populated
             * 3. Click on show prices button
             * 4. Select middle tile (click on button)
             * 5. Make sure that new screen is opened
             */
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            BasePage.CloseCookieBar.Click();
            Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(Locators.WizzAirSelectFlightsLocators.Spinner));
            Wait.Until(ExpectedConditions.ElementToBeClickable(Locators.WizzAirSelectFlightsLocators.ButtonShowPrices));
            SelectFlights.ClosePopup();
            Assert.NotNull(SelectFlights.PageTitle(), "Page title has not been found");
            StringAssert.Contains(_helpers.FlightFromFull, SelectFlights.DestinationPoints().Text, "From Point has not been found");
            StringAssert.Contains(_helpers.FlightToFull, SelectFlights.DestinationPoints().Text, "To Point has not been found");
            Assert.That(SelectFlights.ReturnFlightBlock(), Is.Null, "Return Flights Block is active");
            Assert.That(SelectFlights.ReturnFlightLink(), Is.Not.Null, "Return flights block is populated");
            SelectFlights.ClosePopup();
            SelectFlights.ButtonShowPrices().Click();
            Wait.Until(ExpectedConditions.ElementToBeClickable(SelectFlights.ButtonMiddlePrice()));
            //Assert that prices are displayed
            
            foreach (IWebElement elem in SelectFlights.PricesList()) 
            {
                Assert.IsNotEmpty(elem.Text, "Price is not presented in the list for tile");
            }

            SelectFlights.ButtonMiddlePrice().Click();
            Assert.That(SelectFlights.DivSelectedFlights, Is.Not.Null, "Selected Flight is not presented");
        }

        [Test, Order(3)]
        [Description("Confirming of flight data")]
        public void SelectOffer()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(Locators.WizzAirSelectFlightsLocators.ButtonContinue)); //button have mot be = disabled="disabled"
            SelectFlights.ButtonContinue().Click();
            Assert.That(SelectFlights.ChangedPageTitle().Text, Is.EqualTo("YOUR TRIP TO" + _helpers.FlightToFull.ToUpper()), "Trip points differ from expected");
        }

        [Test, Order(4)]
        [Description("Selecting of passenger data")]
        public void SetPassenger()
        {
            /*1. Set First Name
            2. Set Last Name
            3. Set Gender = Male
            4. Click on continue*/

            Wait.Until(ExpectedConditions.ElementIsVisible(Locators.WizzAirPassengerLuggageLocators.FieldFirstName));
            Assert.That(PassengerAndLuggageData.PageTitle().Text, Is.EqualTo("PASSENGERS AND BAGGAGES"), "Title of page is not Passengers and Baggages");
            PopulateField(PassengerAndLuggageData.FieldFirstName(), (_helpers.PassengerFN));
            Wait.Until(ExpectedConditions.ElementIsVisible(Locators.WizzAirPassengerLuggageLocators.FieldLastName));
            PopulateField(PassengerAndLuggageData.FieldLastName(), _helpers.PassengerLN);
            //Thread.Sleep(1000);
            PassengerAndLuggageData.ButtonPassengerGender().Click();
            Wait.Until(ExpectedConditions.ElementIsVisible(Locators.WizzAirPassengerLuggageLocators.ButtonContinue));
            Assert.That(PassengerAndLuggageData.ButtonContinue().Enabled, Is.True, "Button Continue is not active");
            
            ScrollToElement(PassengerAndLuggageData.ButtonContinue());
            PassengerAndLuggageData.ButtonContinue().Click();  //WHY???????????????????????????????
            PassengerAndLuggageData.ButtonContinue().Submit();

        }

        [Test, Order(5)]
        public void SignInCheck()
        {
            /*Check that title matches expected
            * Check that Email field is presented
            * Check that Password field is presented*/

            Wait.Until(ExpectedConditions.ElementToBeClickable(Locators.WizzAirSignInLocators.FieldEmail));
            Assert.That(SignIn.LabelTitle().Text, Is.EqualTo(_helpers.SignInPageName), "Titles for Sign In page do not match");
            Assert.That(SignIn.FieldEmail, Is.Not.Null, "Not a signIn page. No Email field");
            Assert.That(SignIn.FieldPassword, Is.Not.Null, "Not a signIn page. No Password field");

            //Thread.Sleep(6000);
        }

    }
}
