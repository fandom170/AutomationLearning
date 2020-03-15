using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Pages
{
    public class WizzAirSignIn
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirSignIn (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement FieldEmail => driver.FindElement(By.XPath(Locators.WizzAirSignInLocators.FieldEmail));
        public IWebElement FieldPassword => driver.FindElement(By.XPath(Locators.WizzAirSignInLocators.FieldPassword));
        public IWebElement LabelTitle => driver.FindElement(By.Id(Locators.WizzAirSignInLocators.LableSignInHeader));

    }
}
