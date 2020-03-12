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
    class WizzAirTest : Base.TestBase
    {

        private void WaitUntilIsDisplayed(IWebElement element) 
        {
            Wait.Until(_ => element.Displayed);
        }



        [Test, Order(1)]
        [Description("Click on Find button")]
        public void RunSearch() 
        {

            Assert.That(driver.Title, Is.EqualTo(_helpers.MainPageName), "Titles have differences");
            
            MainPage.FieldFrom.Clear();
            MainPage.FieldFrom.Click();
            MainPage.FieldFrom.SendKeys(_helpers.FlightFrom);

            Thread.Sleep(15000);////////////////////////////////////////
            //Wait.Until(MainPage.LinkRoute.Displayed);

            IWebElement s = driver.FindElement(By.Id(""));
            Wait.Until(_ => s.Displayed);



            MainPage.LinkRoute.Click();

            Thread.Sleep(1500);////////////////////////////////////////

            MainPage.FieldTo.Clear();
            MainPage.FieldTo.SendKeys(_helpers.FlightTo);

            Thread.Sleep(1500); ///////////////////////////////////////

            MainPage.LinkRoute.Click();

            Thread.Sleep(1500);/////////////////////////////////////////

            MainPage.SearchFlight.Click();

            Thread.Sleep(15000);/////////////////////////////////////////

            Assert.NotNull(SelectFlights.PageTitle, "Page title has not been found");
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
            Thread.Sleep(15000);

            SelectFlights.ButtonShowPrices.Click();

            Thread.Sleep(15000);/////////////////////////////////////////////////////////

            SelectFlights.ButtonMiddlePrice.Click();

            Thread.Sleep(15000);/////////////////////////////////////////////////////////

            SelectFlights.ButtonContinue.Click();
            
            //SelectFlights.ButtonShowPrices().Click();
            //SelectFlights.ButtonMiddlePrice().Click();


        }

        [Test, Order(3)]
        [Description("Selecting of offer")]
        public void SelectOffer() 
        { 
        
        }

        [Test, Order(4)]
        [Description("Selecting of passenger data")]
        public void SetPassenger() 
        {

        }

        //Verify that route is correct on the top of the page
        [Test, Order(5)]
        [Description("Check route")]
        public void CheckRoute() 
        { 
        
        }

        //Select any luggage option
        [Test, Order(6)]
        [Description("Select luggage options")]
        public void SelectLuggage()
        {

        }

        //Click Continue
        [Test, Order(7)]
        [Description("Confirm selection and further processing")]
        public void ContinueSelection()
        {

        }

        //Verify that Sign in dialog is displayed
        [Test, Order(8)]
        [Description("Check that Sign in is displayed")]
        public void CheckSignIn()
        {

        }






    }
}
