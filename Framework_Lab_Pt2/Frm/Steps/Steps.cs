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
            _mainPage.EnterCityFrom("");
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
            _mainPage.EnterCityFrom("Минск, MSQ");
            _mainPage.EnterCityTo("Ивацевичи");
        }

        public void EnterLastDate()
        {
            _mainPage.EnterDateFrom("25-12-2018");
            _mainPage.EnterDateTo("22-01-2019");
        }

        public void AddRoute()
        {
            _mainPage.ClickCompositeRoute();
            _mainPage.ClickAddRoute();
        }

        public void BothSide()
        {
            _mainPage.ClickBothSide();
        }

        public bool CheckWinError()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            return _resultPage.CheckErrorWindow();
        }

        public void FlightWithoutTransfers()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            System.Threading.Thread.Sleep(10000);
            _resultPage.ClickTransferCheckbox();
        }

        public void FlightByBelavia()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            System.Threading.Thread.Sleep(10000);
            _resultPage.ChooseBelavia();
        }

        public void FlightByManyAirlines()
        {
            _resultPage = _mainPage.ClickSearchTicket();
            System.Threading.Thread.Sleep(10000);
            _resultPage.ChooseManyAirlines();
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
    }
}

