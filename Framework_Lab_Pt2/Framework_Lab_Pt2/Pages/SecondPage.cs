using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab_Pt2.Pages
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

        public void ClickTransferCheckbox()
        {
            transfer_checkbox.Click();
        }

        public void ChooseBelavia()
        {
            Belaviacheckbox.Click();
        }

        public void ChooseManyAirlines()
        {
            ManyAirlinescheckbox.Click();
        }
        public bool CheckErrorWindow()
        {
            bool exist = true;
            try
            {
                this.driver.FindElement(By.XPath("//i[@class='icon-warning']"));
            }
            catch
            {
                exist = false;
            }
            return exist;
        }

    }
}
