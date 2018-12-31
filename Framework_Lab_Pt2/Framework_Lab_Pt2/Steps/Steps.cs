using Framework_Lab_Pt2.Pages;
using Framework_Lab_Pt2.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab_Pt2.Steps
{
    class Steps
    {
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
            _mainPage.EnterCityFrom("Минск, MSQ");
            _mainPage.EnterCityTo("Москва, MOW");
        }

        public void EnterDates()
        {
            _mainPage.EnterDateFrom("15-01-2019");
            _mainPage.EnterDateTo("29-01-2019");
        }

        public void EnterSimilarCities()
        {
            _mainPage.EnterCityTo("Москва, MOW");
            _mainPage.EnterDateFrom("Москва, MOW");
        }

        public void EnterNonexistentCity()
        {
            _mainPage.EnterCityFrom("Минск");
            _mainPage.EnterCityTo("Муссучипинс");
        }

        public void EnterLastDate()
        {
            _mainPage.EnterDateFrom("28-12-2018");
            _mainPage.EnterDateTo("15-01-2019");
        }

        public void AddRoute()
        {
            _mainPage.ClickCompositeRoute();
            _mainPage.ClickAddRoute();
        }

        public bool CheckWinError()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            return _resultPage.CheckErrorWindow();
        }

        public bool CheckFiltersWork()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            System.Threading.Thread.Sleep(10000);
            _resultPage.ClickButtonFilters();
            _resultPage.ClickOneTransplants();
            _resultPage.ClickTwoTransplants();
            _resultPage.ClickThreeTransplants();
            return _resultPage.CheckAnotherTransplants();
        }

        public bool CheckListValue()
        {
            _mainPage = new MainPage(driver);

            try
            {
                driver.FindElement(By.Id("ui-menu-item"));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}

