using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebDriverHomeworks
{
    [TestFixture]
    public class PageTesting
    {
        IWebDriver driver;
        PageGismeteo pageGismeteo;

        [OneTimeSetUp]
        public void StartBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(_helpers.webDriverPlace);
            driver.Manage().Window.Maximize();
            driver.Url = _helpers.URLGISMETEO;
            pageGismeteo = new PageGismeteo();
            //WebDriverWait wait = new WebDriverWait(driver, waitForElement);
        }

        [Test, Order(0)]
        public void CheckTitle() 
        {
            
            String title = driver.Title;
            Assert.That(title, Is.Not.Null, "Page was not loaded or, at least, does not have a title");
        }
        
        [Test(Description = "Get all Div from the page"), Order(1)]
        public void GetAllDivs() 
        {
            IList<IWebElement> lisOfAllDivs = driver.FindElements(By.TagName("div"));
            foreach (IWebElement webElem in lisOfAllDivs) 
            { 
                //DO NOTHING
            }
            //Console.WriteLine(pageGismeteo);
            Assert.That(lisOfAllDivs.Count() > 0, Is.True, "If you see this message, then any divs has not been found");
        }

        //2. find all div with h1
        [Test(Description = "Get all divs with h1"), Order(2)]
        public void GetH2Divs() 
        {
            IList<IWebElement> lisOfAllH2Divs = driver.FindElements(By.XPath(Locators.GisMeteoLocators.DivWithH1));
            foreach (IWebElement webElem in lisOfAllH2Divs)
            {
                //DO NOTHING
            }
            Assert.That(lisOfAllH2Divs.Count() > 0, Is.True, "If you see this message, then any divs with h2 tag has not been found");
        }

        //3. find all elements with news tiles
        [Test(Description = "Get all div with news"), Order(3)]
        public void GetAllNews() 
        {
            IList<IWebElement> ListOfNews = driver.FindElements(By.CssSelector(Locators.GisMeteoLocators.AllNewsTiles));
            Assert.IsNotNull(ListOfNews,  "");
        }

        //4. Find the last element from news tiles////////////////////////////////////////////////
        [Test(Description = ""), Order(4)]
        public void GetLastSpan() 
        {
            IWebElement LastNews = driver.FindElement(By.XPath(Locators.GisMeteoLocators.LastNewsElement));
            Assert.IsNotNull(LastNews, "");
        }

        //5. Get all titles from items from #3
        [Test]
        [Description("Get title from elements 3"), Order(5)]
        public void GetTitles() 
        {
            List<string> TitlesList = new List<string>();

            IList <IWebElement> newsTiles = driver.FindElements(By.CssSelector(Locators.GisMeteoLocators.TitlesFromNews));
            foreach (IWebElement elem in newsTiles) 
            {
                TitlesList.Add(elem.Text);
                Assert.IsNotNull(elem.Text, "");
            }
            Assert.That(TitlesList.Count, Is.GreaterThan(0), "List is empty");
        }
        
        //6. Find element with text ...////////////////////////////////////////////////////////
        [Test]
        [Description ("Get element by text content"), Order(6)]
        public void GetElementByName() 
        {
            string cityName = "Bradford";
            IWebElement сity = driver.FindElement(By.XPath(".//div[@class = 'cities_item']//span[contains(text(), '" + cityName + "')]"));
            Assert.IsNotNull(сity);
        }

        //7. Find the element that describes city next after another city
        [Test]
        [Description("Get next element after particular lement"), Order(7)]
        public void GetNextElement() 
        {
            string cityName = "London";
            IWebElement nextCity = driver.FindElement(By.XPath($".//*[contains(text(), {cityName})]/ancestor::div/a"));
            Assert.IsNotNull(nextCity);
        }
        //8. Find all top menu link
        [Test]
        [Description("Get element by css using tag"), Order(8)]
        public void GetAllLinksFromMenu() 
        {
            IList<IWebElement> linkedMenu = driver.FindElements(By.CssSelector(Locators.GisMeteoLocators.ItemsFromTopMenu));
            Assert.IsNotNull(linkedMenu);
        }

        //9. On the current city weather page find element for 3 current weekdays.
        [Test, Order(9)]
        [Description("Find 3-days link")]
        public void GetThreeDaysLink() 
        {
            IWebElement threeDaysLink = driver.FindElement(By.XPath(Locators.GisMeteoLocators.ThreeDaysLink));
            Assert.That(threeDaysLink, Is.Not.Null, "Three days link element was not found");
        }

        //10. Find element for currently selected weekday
        [Test, Order(10)]
        [Description("Find current weekday")]
        public void GetCurrentWeekDay() 
        {
            DateTime now = DateTime.Now;
            
            string date = driver.FindElement(By.XPath(Locators.GisMeteoLocators.CurrentWeekDay)).Text;
            Assert.That(date, Is.EqualTo(now.ToString("ddd, d MMMM, HH:mm")));
            
        }
        
        //11. Find temperature when it's Малооблачно (1 element!!)
        [Test, Order(11)]
        [Description("Get temperature using axis")]
        public void GetTemperature()
        {
            //IWebElement TemperatureDate = driver.FindElement(By.XPath(".//span[@class = 'tooltip' and contains(@data-text, 'Малооблачно')]/following-sibling           //span[contains(@class, unit_temperature_c)]"));
            int counter = 1;
            IList<IWebElement> weatherForecast = driver.FindElements(By.XPath(".//div[contains(@class, '_line iconline clearfix')]//span[@class = 'tooltip']"));

            IWebElement WeatherAlmostsunny = driver.FindElement(By.XPath(".//div[@class = 'weather_item']//span[@class = 'tooltip' and contains(text(), 'Малооблачно')]/ancestor:div[@class ='_line iconline clearfix']/following-sibling::"));

            foreach (IWebElement elem in weatherForecast) 
            {

                if (elem.Text.Equals("Малооблачно")) 
                {
                    break;
                }
                counter++;
            }
            IWebElement temperature = driver.FindElement(By.XPath(".//div[contains(@class, 'chart chart__temperatureNearest')]/div/div['" + counter + "']"));
            Assert.IsNotNull(temperature.Text, "Appropriaete element has not been found");
        }


        [OneTimeTearDown]
        public void ClosePage() 
        {
            driver.Close();
            driver.Quit();
        }
    }
}
