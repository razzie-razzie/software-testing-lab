using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework_Lab
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Clean_Up()
        {
            steps.CloseBrowser();
        }

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
    }
}
