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

            Assert.IsTrue(steps.IsDisabledDateTo());
        }

        //2
        [Test]
        public void CheckCitiesInversing()
        {
            steps.OpenMainPage();

            steps.EnterCities();
            var city_from = steps.GetCityFromValue();
            var city_to = steps.GetCityToValue();
            steps.InverseCities();

            Assert.IsTrue(steps.GetCityFromValue() == city_to && steps.GetCityToValue() == city_from);

        }

        //3
        [Test]
        public void CheckSimilarCity()
        {
            steps.OpenMainPage();

            steps.EnterSimilarCities();

            Assert.AreEqual(steps.GetCityFromValue(), steps.GetCityToValue());
        }

        //4
        [Test]
        public void CheckChoosingBuisnessClass()
        {
            steps.OpenMainPage();

            steps.DisplayList();
            steps.ChooseBuisnessClass();

            Assert.IsTrue(steps.IsBuisnessClassChecked());

        }

        //5
        [Test]
        public void CheckCompositeRoute()
        {
            steps.OpenMainPage();

            steps.CompositeRoute();

            Assert.AreEqual(true, steps.GetAddRoute().Displayed);

        }

        //6
        [Test]
        public void CheckBothSidesActivates()
        {
            steps.OpenMainPage();

            steps.BothSide();

            Assert.IsTrue(steps.GetDateFrom().Enabled);
        }

        //7
        [Test]
        public void CheckEnterCities()
        {
            steps.OpenMainPage();

            steps.EnterCities();

            Assert.IsTrue(steps.GetCityFromValue() == steps.city_from_name && steps.GetCityToValue() == steps.city_to_name);
        }

        //8
        [Test]
        public void CheckAddAdultsChildrenandBaby()
        {
            steps.OpenMainPage();

            steps.DisplayList();
            int adults = steps.GetAdultCount();
            int children = steps.GetChildrenCount();
            int babies = steps.GetBabyCount();

            steps.AddAdult();
            steps.AddChild();
            steps.AddBaby();

            Assert.IsTrue(steps.GetAdultCount() == (adults + 1) &&
                          steps.GetChildrenCount() == (children + 1) &&
                          steps.GetBabyCount() == (babies + 1));
        }

        //9
        [Test]
        public void CheckAddandDelRoute()
        {
            try
            {
                steps.OpenMainPage();

                steps.AddRoute();
                steps.DelRoute();
            }
            catch (Exception ex)
            {
                Assert.Equals(ex.Message, "NoSuchElementException");
            }

        }

        //10
        [Test]
        public void CheckAddRoute()
        {
            steps.OpenMainPage();

            steps.AddRoute();

            Assert.AreEqual(true, steps.GetAddedRouteCity().Displayed);

        }
    }
}

