using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    static class WizzAirSignInLocators
    {
        public static By FieldEmail =           By.XPath(".//input[@name = 'email' and @type = 'email']"); //xpath
        public static By FieldPassword =        By.XPath(".//input[@name = 'password' and @type = 'password']"); //xpath
        public static By LableSignInHeader =    By.CssSelector("header.modal__header h2");
        public static By ButtonSignIn =         By.CssSelector("div.modal__body div: nth - of - type(5) button");
    }
}
