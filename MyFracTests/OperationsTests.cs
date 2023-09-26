using laba2_3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFracTests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void PlusSame()
        {
            MyFrac m1 = new MyFrac(2,7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(5, 7).ToString();
            string actual = MyFrac.Plus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Plus method doesn't work right");
        }
        [TestMethod]
        public void PlusDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 5);
            string expected = new MyFrac(31, 35).ToString();
            string actual = MyFrac.Plus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Plus method doesn't work right");
        }
        [TestMethod]
        public void PlusSimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(12, 7);
            string expected = new MyFrac(2, 1).ToString();
            string actual = MyFrac.Plus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Plus method doesn't work right");
        }
        [TestMethod]
        public void PlusDifferentSigns()
        {
            MyFrac m1 = new MyFrac(3, 8);
            MyFrac m2 = new MyFrac(-3, 16);
            string expected = new MyFrac(3, 16).ToString();
            string actual = MyFrac.Plus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Plus method doesn't work right");
        }
        [TestMethod]
        public void MinusSame()
        {
            MyFrac m1 = new MyFrac(3, 7);
            MyFrac m2 = new MyFrac(5, 7);
            string expected = new MyFrac(-2, 7).ToString();
            string actual = MyFrac.Minus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Minus method doesn't work right");
        }
        [TestMethod]
        public void MinusDifferent()
        {
            MyFrac m1 = new MyFrac(3, 6);
            MyFrac m2 = new MyFrac(2, 7);
            string expected = new MyFrac(3, 14).ToString();
            string actual = MyFrac.Minus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Minus method doesn't work right");
        }
        [TestMethod]
        public void MinusSimplifying()
        {
            MyFrac m1 = new MyFrac(10, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(1, 1).ToString();
            string actual = MyFrac.Minus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Minus method doesn't work right");
        }
        [TestMethod]
        public void MinusDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(5, 7).ToString();
            string actual = MyFrac.Minus(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Minus method doesn't work right");
        }
        [TestMethod]
        public void MultiplySame()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(6, 49).ToString();
            string actual = MyFrac.Multiply(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 8);
            string expected = new MyFrac(6, 56).ToString();
            string actual = MyFrac.Multiply(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplySimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 9);
            string expected = new MyFrac(2, 21).ToString();
            string actual = MyFrac.Multiply(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(-6, 49).ToString();
            string actual = MyFrac.Multiply(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void DivideSame()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(2, 3).ToString();
            string actual = MyFrac.Divide(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(5, 9);
            string expected = new MyFrac(18, 35).ToString();
            string actual = MyFrac.Divide(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideSimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 9);
            string expected = new MyFrac(6, 7).ToString();
            string actual = MyFrac.Divide(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(-2, 3).ToString();
            string actual = MyFrac.Divide(m1, m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
    }
}
