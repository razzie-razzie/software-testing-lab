using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Lab_Pt2.Tests
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
        public void CheckFilterWork()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            steps.EnterDates();

            Assert.AreEqual(true, steps.CheckFiltersWork());
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
        public void Test6()
        {
            steps.OpenMainPage();
        }

        //7
        [Test]
        public void Test7()
        {
            steps.OpenMainPage();
        }

        //8
        [Test]
        public void Test8()
        {
            steps.OpenMainPage();
        }

        //9
        [Test]
        public void Test9()
        {
            steps.OpenMainPage();
        }

        //10
        [Test]
        public void Test10()
        {
            steps.OpenMainPage();
        }
    }
}

