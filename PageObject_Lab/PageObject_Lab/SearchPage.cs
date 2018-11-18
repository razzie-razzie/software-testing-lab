using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace PageObject_Lab
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
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

        [FindsBy(How = How.ClassName, Using = "md-checked")]
        private ReadOnlyCollection<IWebElement> Airlines;

        public bool CheckAirline(string text)
        {
            bool unique = true;
            foreach (var airline in Airlines)
            {
                if (airline.FindElement(By.XPath("//p[@class='']")).Text != text)
                {
                    unique = false;
                    break;
                }
            }
            return unique;
        }
    }
}
