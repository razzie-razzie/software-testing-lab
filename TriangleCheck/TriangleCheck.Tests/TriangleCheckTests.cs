using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleCheck.Tests
{
    [TestClass]
    public class TriangleCheckTests
    {
        [TestMethod] /*1*/
        public void TriangleCheck_return_false()
        {
            //arrange
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(7, 5, 13);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*2*/
        public void TriangleCheck_return_true()
        {
            //arrange
            bool expected = true;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(5, 8, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*3*/
        public void TriangleCheck_minus_return_false()
        {
            //arrange
            int a = -3;
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, 4, 5);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*4*/
        public void TriangleCheck_all_nulls_return_false()
        {
            //arrange
            int a = 0;
            int b = 0;
            int c = 0;
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*5*/
        public void TriangleCheck_b_0_return_false()
        {
            //arrange
            int b = 0;
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(8, b, 2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*6*/
        public void TriangleCheck_a_and_c_0_return_false()
        {
            //arrange
            int a = 0;
            int c = 0;
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, 7, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*7*/
        public void TriangleCheck_all_the_same_return_true()
        {
            //arrange
            int a, b, c;
            a = b = c = 5;
            bool expected = true;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*8*/
        public void TriangleCheck_double_return_true()
        {
            //arrange
            double a = 3.14;
            bool expected = true;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, 4, 5);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*9*/
        public void TriangleCheck_a0_b_minus5_return_false()
        {
            //arrange
            int a = 0;
            int b = -5;
            bool expected = false;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, b, 5);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] /*10*/
        public void TriangleCheck_string_to_double_return_true()
        {
            //arrange
            string a_str = "1,25";
            double a = Convert.ToDouble(a_str);
            bool expected = true;

            //act
            TriangleCheck tr = new TriangleCheck();
            bool actual = tr.Triangle_Check(a, 4, 5);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
