using Framework_Lab.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab.Steps
{
    class Steps
    {
        public string city_from_name = "Минск, MSQ";
        public string city_to_name = "Москва, MOW";

        IWebDriver driver;

        private MainPage _mainPage { get; set; }

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenMainPage()
        {
            _mainPage = new MainPage(driver);

            _mainPage.OpenPage();
        }

        public void EnterCities()
        {
            _mainPage.EnterCityFrom(city_from_name);
            _mainPage.EnterCityTo(city_to_name);
        }

        public string GetCityFromValue()
        {
            var city_from = _mainPage.city_from;
            return Convert.ToString(city_from.GetAttribute("value"));
        }

        public string GetCityToValue()
        {
            var city_to = _mainPage.city_to;
            return Convert.ToString(city_to.GetAttribute("value"));
        }

        public void InverseCities()
        {
            _mainPage.ClickInverseBtn();
        }
    }
}
