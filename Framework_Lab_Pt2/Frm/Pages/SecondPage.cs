using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Pages
{
    class SecondPage
    {
        private const string BASE_URL = "https://www.euroavia.ru/";

        [FindsBy(How = How.Id, Using = "stops1")]
        private IWebElement transfer_checkbox;

        [FindsBy(How = How.Id, Using = "B2")]
        private IWebElement Belaviacheckbox;

        [FindsBy(How = How.Id, Using = "owcAirlines")]
        private IWebElement ManyAirlinescheckbox;

        private IWebDriver driver;

        public SecondPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
 

    }
}
