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
        [FindsBy(How = How.Id, Using = "stops1")]
        public IWebElement transfer_checkbox;

        [FindsBy(How = How.Id, Using = "B2")]
        public IWebElement Belaviacheckbox;

        [FindsBy(How = How.Id, Using = "owcAirlines")]
        public IWebElement ManyAirlinescheckbox;

        private IWebDriver driver;

        public SecondPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
 

    }
}
