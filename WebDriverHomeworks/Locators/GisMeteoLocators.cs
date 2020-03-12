using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverHomeworks.Locators
{
    public static class GisMeteoLocators
    {
        public static string DivWithH1 = ".//div[@h1]";
        public static string AllNewsTiles = ".readmore_item";

        public static string TitlesFromNews = ".readmore_title";

        public static string ItemsFromTopMenu = "li.nav_item a";

        public static string LastNewsElement = ".//*[@class = 'readmore_list']/div[last()]";

        public static string ThreeDaysLink = ".//li[@class = 'nolink subnav_item']//a[contains(text(), '3')]";

        public static string CurrentWeekDay = ".//div[@id = 'time']/span";

        public static string CurrentTemp = ".//div[contains(@class, 'description gray')]/ancestor::div[@class = 'wn_body']//div[@data-type = 'temperature']";
    }
}
