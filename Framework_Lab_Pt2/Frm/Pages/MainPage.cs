using Frm.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Pages
{
    class MainPage
    {
        private const string BASE_URL = "https://santufei.com";

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[6]/button")]
        public IWebElement search_btn;

        [FindsBy(How = How.Id, Using = "city-from__input")]
        public IWebElement city_from;

        [FindsBy(How = How.Id, Using = "city-to__input")]
        public IWebElement city_to;

        [FindsBy(How = How.Id, Using = "date-from__input")]
        public IWebElement date_from;

        [FindsBy(How = How.Id, Using = "date-to__input")]
        public IWebElement date_to;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[1]/div[1]/md-nav-bar/div/nav/ul/li[3]/button")]
        public IWebElement composite_route_btn;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[3]/div[2]/a")]
        public IWebElement add_route_btn;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[1]/div[1]/md-nav-bar/div/nav/ul/li[2]/button/span")]
        public IWebElement both_side_btn;

        [FindsBy(How = How.Id, Using = "city-complexf-2")]
        public IWebElement added_city;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[3]/form[3]/a")]
        public IWebElement del_route_btn;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[1]/div/span")]
        public IWebElement inverse_cities_btn;

        [FindsBy(How = How.Id, Using = "pass-count")]
        public IWebElement list_passenger_class;

        [FindsBy(How = How.XPath, Using = "//*[@id='radio_1']/div[1]/div[1]")]
        public IWebElement buisness_class;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[1]/td[2]/div/a[2]")]
        public IWebElement add_adult;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[2]/td[2]/div/a[2]")]
        public IWebElement add_child;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[3]/td[2]/div/a[2]")]
        public IWebElement add_baby;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[1]/td[2]/div/div")]
        public IWebElement adult_counter;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[2]/td[2]/div/div")]
        public IWebElement children_counter;

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[5]/div/table/tbody/tr[3]/td[2]/div/div")]
        public IWebElement baby_counter;

        public IWebDriver driver;

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

        public void ClickDelRoute()
        {
            del_route_btn.Click();
        }

        public void ClickBothSide()
        {
            both_side_btn.Click();
        }

        public void ClickInverseBtn()
        {
            inverse_cities_btn.Click();
        }

        public void ClickList()
        {
            list_passenger_class.Click();
        }

        public void ClickBuisnessClass()
        {
            buisness_class.Click();
        }

        public void ClickAddAdult()
        {
            add_adult.Click();
        }

        public void ClickAddChild()
        {
            add_child.Click();
        }

        public void ClickAddBaby()
        {
            add_baby.Click();
        }

    }
}
