using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject_Lab
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            try
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(exc.Message);
            }

        }


        [FindsBy(How = How.Id, Using = "city-from__input")]
        private IWebElement city_from;

        [FindsBy(How = How.Id, Using = "city-to__input")]
        private IWebElement city_to;

        [FindsBy(How = How.Id, Using = "date-from__input")]
        private IWebElement date_from;

        [FindsBy(How = How.Id, Using = "date-to__input")]
        private IWebElement date_to;


        public SearchPage goToSearch()
        {
            city_from.SendKeys("Минск, MSQ");
            city_to.SendKeys("Москва, MOW");
            date_from.SendKeys("12-10-2018");
            date_to.SendKeys("12-15-2018");
            return new SearchPage(driver);
        }
    }
}
