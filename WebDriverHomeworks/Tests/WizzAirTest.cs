using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks
{
    [TestFixture]
    class WizzAirTest : Base.TestBase
    {
        

        [Test, Order(0)]
        [Description("Click on Find button")]
        public void RunSearch() 
        {
            MainPage.FieldFrom().Clear();
            MainPage.FieldFrom().SendKeys(_helpers.FlightFrom);
            MainPage.FieldTo().Clear();
            MainPage.FieldTo().SendKeys(_helpers.FlightTo);
            MainPage.SearchFlight().Click();
            
        }

        [Test, Order(1)]
        [Description("Verify flight data")]
        public void VerifyData() 
        { 
        
        }

        [Test, Order(2)]
        [Description("Selecting of offer")]
        public void SelectOffer() 
        { 
        
        }

        [Test, Order(3)]
        [Description("Selecting of passenger data")]
        public void SetPassenger() 
        {

        }

        //Verify that route is correct on the top of the page
        [Test, Order(4)]
        [Description("Check route")]
        public void CheckRoute() 
        { 
        
        }

        //Select any luggage option
        [Test, Order(5)]
        [Description("Select luggage options")]
        public void SelectLuggage()
        {

        }

        //Click Continue
        [Test, Order(6)]
        [Description("Confirm selection and further processing")]
        public void ContinueSelection()
        {

        }

        //Verify that Sign in dialog is displayed
        [Test, Order(7)]
        [Description("Check that Sign in is displayed")]
        public void CheckSignIn()
        {

        }






    }
}
