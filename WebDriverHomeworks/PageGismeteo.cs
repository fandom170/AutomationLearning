using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverHomeworks
{
    class PageGismeteo
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//div")]
        public IWebElement AllDiv { get; set; }

    }
}
