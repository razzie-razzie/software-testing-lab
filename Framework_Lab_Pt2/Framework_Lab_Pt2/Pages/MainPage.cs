using Framework_Lab_Pt2.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab_Pt2.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://santufei.com";

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-orn']")]
        private IWebElement SearchTicket_btn;

        [FindsBy(How = How.Id, Using = "city-from__input")]
        private IWebElement city_from;

        [FindsBy(How = How.Id, Using = "city-to__input")]
        private IWebElement city_to;

        [FindsBy(How = How.Id, Using = "date-from__input")]
        private IWebElement date_from;

        [FindsBy(How = How.Id, Using = "date-to__input")]
        private IWebElement date_to;

        [FindsBy(How = How.XPath, Using = "//span[@class='search-button input-group-btn']")]
        private IWebElement search_btn;

        [FindsBy(How = How.XPath, Using = "//span[@class='_md-nav-button md-accent md-button md-ink-ripple md-active md-primary']")]
        private IWebElement composite_route_btn;

        [FindsBy(How = How.XPath, Using = "//span[@class='add-flight col-xs-6 ng-scope']")]
        private IWebElement add_route_btn;


        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void EnterCityFrom(string city)
        {
            city_from.Clear();
            city_from.SendKeys(city);
        }

        public void EnterCityTo(string city)
        {
            city_to.Clear();
            city_to.SendKeys(city);
        }

        public void EnterDateFrom(string date)
        {
            date_from.Clear();
            date_from.SendKeys(date);
            city_from.SendKeys(Keys.Enter);
        }

        public void EnterDateTo(string date)
        {
            date_to.Clear();
            date_to.SendKeys(date);
            city_from.SendKeys(Keys.Enter);
        }

        public SecondPage ClickSearchTicket()
        {
            search_btn.Click();
            return new SecondPage(DriverClass.GetInstance());
        }

        public void ClickCompositeRoute()
        {
            composite_route_btn.Click();
        }

        public void ClickAddRoute()
        {
            add_route_btn.Click();
        }
    }
}
