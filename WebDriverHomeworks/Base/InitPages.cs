using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Base
{
    public class InitPages
    {

        public IWebDriver driver;
        public Pages.WizzAirMain MainPage;
        public Pages.WizzAirSelectFlights SelectFlights;
        public Pages.WizzAirPassengerDataLuggage PagePassengerData;
        public Pages.WizzAirSignIn SignIn;

        [Obsolete]
        public void initPages(IWebDriver driver)
        {
            MainPage = new Pages.WizzAirMain(driver);
            SelectFlights = new Pages.WizzAirSelectFlights(driver);
            PagePassengerData = new Pages.WizzAirPassengerDataLuggage(driver);
            SignIn = new Pages.WizzAirSignIn(driver);
        }
    
    }
}
