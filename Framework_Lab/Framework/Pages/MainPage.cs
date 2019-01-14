using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab.Pages
{
    public class MainPage
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

        [FindsBy(How = How.XPath, Using = "//*[@id='airlines']/div/div/div[2]/form[1]/div[1]/div/span")]
        public IWebElement inverse_cities_btn;

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

        public void ClickInverseBtn()
        {
            inverse_cities_btn.Click();
        }
    }
}
