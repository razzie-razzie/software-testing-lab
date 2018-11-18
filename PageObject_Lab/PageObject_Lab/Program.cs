using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_Lab
{
    class Program
    {
        private const string site_url = "https://santufei.com";
        private static WebDriverWait Wait;

        [Test]
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = site_url;
            HomePage homePage = new HomePage(driver);
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));

            SearchPage searchPage = homePage.goToSearch();

            Assert.AreEqual(true, searchPage.CheckAirline("Belavia"));

            driver.Quit();
        }
    }
}
