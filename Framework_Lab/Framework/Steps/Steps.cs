using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework_Lab.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void EnterCities(string city_from, string city_to)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.EnterCityFrom(city_from);
            mainPage.EnterCityTo(city_to);
            mainPage.EnterDateFrom("9.12.2018");
            mainPage.EnterDateTo("19.12.2018");
        }
    }
}
