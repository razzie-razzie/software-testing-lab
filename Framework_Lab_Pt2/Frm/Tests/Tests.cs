using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm.Tests
{
    [TestFixture]
    class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        //1
        [Test]
        public void CheckEnterNothing()
        {
            steps.OpenMainPage();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //2
        [Test]
        public void CheckDateChecking()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterLastDate();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //3
        [Test]
        public void CheckSimilarCity()
        {
            steps.OpenMainPage();

            steps.EnterSimilarCities();
            steps.EnterDates();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //4
        [Test]
        public void CheckExistenceCity()
        {
            steps.OpenMainPage();

            steps.EnterNonexistentCity();
            steps.EnterDates();

            Assert.AreEqual(false, steps.CheckListValue());
        }

        //5
        [Test]
        public void CheckRoutesAdded()
        {
            steps.OpenMainPage();

            steps.AddRoute();

            Assert.AreEqual(true, steps.CheckWinError());

        }

        //6
        [Test]
        public void CheckBothSidesActivates()
        {
            steps.OpenMainPage();

            steps.BothSide();
            steps.EnterCities();

            Assert.IsTrue(steps.GetBorthSidesBtn().Enabled);
        }

        //7
        [Test]
        public void CheckAllSuccess()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterDates();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //8
        [Test]
        public void CheckWithoutTransfer()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterDates();
            steps.FlightWithoutTransfers();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //9
        [Test]
        public void CheckChoosingBelavia()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterDates();
            steps.FlightByBelavia();

            Assert.AreEqual(true, steps.CheckWinError());
        }

        //10
        [Test]
        public void CheckChoosingManyAorlines()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterDates();
            steps.FlightByManyAirlines();

            Assert.AreEqual(true, steps.CheckWinError());
        }
    }
}
 
