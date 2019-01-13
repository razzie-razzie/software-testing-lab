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

        [TestCase]
        public void Test1()
        {
            steps.EnterCities("Минск, MSQ", "Москва, MOW");

        }
    }
}
