using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Pages
{
    public class WizzAirBasePage
    {
        private IWebDriver driver;

        [Obsolete]
        public WizzAirBasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement CloseCookieBar => driver.FindElement(By.CssSelector(Locators.BasePageLocators.CookiesBar));
    }
}
