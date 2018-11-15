using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver chrm = new ChromeDriver();
                chrm.Url = "https://santufei.com";

                chrm.FindElement(By.Id("city-from__input")).SendKeys("Минск, MSQ");
                chrm.FindElement(By.Id("city-to__input")).SendKeys("Москва, MOW");
                chrm.FindElement(By.Id("date-from__input")).SendKeys("10-12-2018");
                chrm.FindElement(By.ClassName("btn btn-orn")).Click();
            }

            catch (NoSuchElementException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
