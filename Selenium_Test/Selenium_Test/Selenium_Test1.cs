using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Selenium_Test
{
    [TestClass]
    public class Selenium_Test1
    {
        private IWebDriver driver { get; set; }

        public string city_from_name = "Минск, MSQ";
        public string city_to_name = "Москва, MOW";

        [TestInitialize]
        public void Before()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://santufei.com");
        }

        [TestMethod]
        public void EnterCitiesTest()
        {
            var city_from = driver.FindElement(By.Id("city-from__input"));
            var city_to = driver.FindElement(By.Id("city-to__input"));

            city_from.SendKeys(city_from_name);
            city_to.SendKeys(city_to_name);

            var inputed_city_from = city_from.GetAttribute("value").ToString();
            var inputed_city_to = city_to.GetAttribute("value").ToString();

            Assert.IsTrue(inputed_city_from == city_from_name && inputed_city_to == city_to_name);
        }

        [TestCleanup]
        public void After()
        {
            driver.Quit();
        }
    }
}


