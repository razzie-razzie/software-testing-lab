using Frm.Driver;
using Frm.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Steps
{
    class Steps
    {
        public string city_from_name = "Минск, MSQ";
        public string city_to_name = "Москва, MOW";
        private IWebDriver driver;

        private MainPage _mainPage { get; set; }

        private SecondPage _resultPage { get; set; }
        public void InitBrowser()
        {
            driver = DriverClass.GetInstance();
        }

        public void CloseBrowser()
        {
            DriverClass.CloseBrowser();
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

        public void EnterDates()
        {
            _mainPage.EnterDateFrom("23.01.2019");
            _mainPage.EnterDateTo("05.02.2019");
        }

        public void EnterSimilarCities()
        {
            _mainPage.EnterCityFrom(city_to_name);
            _mainPage.EnterCityTo(city_to_name);
        }

        public void EnterNonexistentCity()
        {
            _mainPage.EnterCityFrom(city_to_name);
            _mainPage.EnterCityTo("Ивацевичи");
        }

        public void CompositeRoute()
        {
            _mainPage.ClickCompositeRoute();
        }

        public void AddRoute()
        {
            _mainPage.ClickCompositeRoute();
            _mainPage.ClickAddRoute();
        }

        public void DelRoute()
        {
            _mainPage.ClickDelRoute();
        }

        public void BothSide()
        {
            _mainPage.ClickBothSide();
        }

        public void InverseCities()
        {
            _mainPage.ClickInverseBtn();
        }

        public void ChooseBuisnessClass()
        {
            _mainPage.ClickList();
            _mainPage.ClickBuisnessClass();
        }

        public bool CheckListValue()
        {
            _mainPage = new MainPage(driver);

            try
            {
                driver.FindElement(By.ClassName("dropdown-menu _city"));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public IWebElement GetBothSidesBtn()
        {
            return _mainPage.both_side_btn;
        }

        public IWebElement GetDateFrom()
        {
            return _mainPage.date_from;
        }

        public IWebElement GetDateTo()
        {
            return _mainPage.date_to;
        }

        public IWebElement GetAddRoute()
        {
            return _mainPage.add_route_btn;
        }

        public IWebElement GetAddedRouteCity()
        {
            return _mainPage.added_city;
        }

        public IWebElement GetBuisnessClassBtn()
        {
            return _mainPage.buisness_class_btn;
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

        public bool IsDisabledDateTo()
        {
            string class_name = GetDateTo().GetAttribute("class");
            if (class_name.Contains("disabled "))
            {
                return true;
            }
            return false;
        }

        public bool IsBuisnessClassChecked()
        {
            string isChecked = GetBuisnessClassBtn().GetAttribute("aria-checked");
            if (isChecked == "false")
            {
                return false;
            }
            return true;
        }
    }
}

