using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework_Lab.Pages
{
    public class MainPage
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

        public void EnterCityFrom(string departureCity)
        {
            city_from.SendKeys(departureCity);
        }

        public void EnterCityTo(string arrivalCity)
        {
            city_to.SendKeys(arrivalCity);
        }

        public void EnterDateFrom(string twoDaysAgoDate)
        {
            date_from.SendKeys(twoDaysAgoDate);
        }

        public void EnterDateTo(string twoDaysAgoDate)
        {
            date_to.SendKeys(twoDaysAgoDate);
        }

        public void SearchTicketBtn_Click()
        {
            SearchTicket_btn.Click();
        }
    }
}
