using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    static class WizzAirSignInLocators
    {
        

        public static string FieldEmail = ".//input[@name = 'email' and @type = 'email']"; //xpath
        public static string FieldPassword = ".//input[@name = 'password' and @type = 'password']"; //xpath

        public static string LableSignInHeader = "modal__header__WZZP0Pw-fqdSpZdJs5zTj"; //id
    }
}
