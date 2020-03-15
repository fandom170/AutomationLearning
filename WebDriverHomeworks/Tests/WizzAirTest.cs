using NUnit.Framework;
using OpenQA.Selenium;
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

        Func<IWebDriver, bool> waitForRoutePoint = new Func<IWebDriver, bool>((IWebDriver Web) =>
        {
            IWebElement element = Web.FindElement(By.CssSelector(Locators.WizzAirMainPageLocators.RouteSelection));
            if (element.Displayed)
            {
                return true;
            }
            return false;
        });





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

            Thread.Sleep(15000);

            Assert.That(driver.Title, Is.EqualTo(_helpers.MainPageName), "Titles have differences");

            MainPage.FieldFrom.Clear();
            MainPage.FieldFrom.Click();
            MainPage.FieldFrom.SendKeys(_helpers.FlightFrom);

            Thread.Sleep(15000);////////////////////////////////////////
            Wait.Until(waitForRoutePoint);
            MainPage.LinkRoute.Click();
            MainPage.FieldTo.Clear();
            MainPage.FieldTo.SendKeys(_helpers.FlightTo);
            Thread.Sleep(1500);////////////////////////////////////////
            Wait.Until(waitForRoutePoint);

            MainPage.LinkRoute.Click();
            MainPage.SearchFlight.Click();

            Thread.Sleep(10000);/////////////////////////////////////////
            
        }

        [Test, Order(2)]
        [Description("Verify flight data")]
        public void VerifyData()
        {
            /*1. Get selected date/make sure that at least one tile is selectable
             * 2. Check From and To labels
             * 2. Make sure that reverce flight is not populated
             * 3. Click on show prices button
             * 4. Select middlw tile (click on button)
             * 5. Make sure that new screen is opened
             */
            //SwitchToNewTab(1);
            //SwitchToNewTab("Wizz Air");
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(100000);
            Assert.NotNull(SelectFlights.PageTitle, "Page title has not been found");
            StringAssert.Contains(SelectFlights.DestinationPoints.Text, _helpers.FlightFromFull, "From Point has not been found");
            StringAssert.Contains(SelectFlights.DestinationPoints.Text, _helpers.FlightToFull, "To Point has not been found");
            SelectFlights.ButtonShowPrices.Click();
            Thread.Sleep(3000);/////////////////////////////////////////////////////////
            SelectFlights.ButtonMiddlePrice.Click();
            Thread.Sleep(3000);/////////////////////////////////////////////////////////
            //Assert That //screen changes

        }

        [Test, Order(3)]
        [Description("Confirming of flight data")]
        public void SelectOffer()
        {
            Thread.Sleep(20000);
            Assert.That(SelectFlights.ChangedPageTitle.Text, Is.EqualTo("Your trip to " + _helpers.FlightToFull), "Expected Textt was returned");
            SelectFlights.ButtonContinue.Click();
            
            //Assert that page is changed
        }

        [Test, Order(4)]
        [Description("Selecting of passenger data")]
        public void SetPassenger()
        {
            /*1. Set First Name
             2. Set Last Name
             3. Set Gender = Male
             4. Click on continue*/

            Thread.Sleep(10000);
            //Assert page title
            PagePassengerData.FieldFirstName.Clear();
            PagePassengerData.FieldFirstName.SendKeys(_helpers.PassengerFN);
            PagePassengerData.FieldLastName.Clear();
            PagePassengerData.FieldLastName.SendKeys(_helpers.PassengerLN);
            PagePassengerData.ButtonPassengerGender.Click();
            Thread.Sleep(10000);
        }

        [Test, Order(5)]
        public void SignInCheck()
        {
            /*Check that title matches expected
             * Check that Email field is presented
             * Check that Password field is presented*/
            Assert.That(SignIn.LabelTitle, Is.EqualTo(_helpers.SignInPageName), "Titles for Sign In page do not match");

        }



    }
}
