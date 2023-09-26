using laba2_3_2;

namespace MyFracTests
{
    [TestClass]
    public class ConstructorTests
    {
        [TestMethod]
        public void FracWithoutSimplifying1()
        {
            string expected = "5/17";
            string actual = new MyFrac(5,17).ToString();
            Assert.AreEqual(expected,actual,"Constructor works wrong");
        }
        [TestMethod]
        public void FracWithoutSimplifying2()
        {
            string expected = "35/13";
            string actual = new MyFrac(35, 13).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void FracWithSimplifying1()
        {
            string expected = "1/3";
            string actual = new MyFrac(5, 15).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void FracWithSimplifying2()
        {
            string expected = "4/1";
            string actual = new MyFrac(12, 3).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void Frac1()
        {
            string expected = "1/1";
            string actual = new MyFrac(21, 21).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void FracDenominativeZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new MyFrac(6,0));
        }
        [TestMethod]
        public void ZeroFrac()
        {
            string expected = "0/1";
            string actual = new MyFrac(0, 25).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void FracMinusToNominative()
        {
            string expected = "-4/15";
            string actual = new MyFrac(4, -15).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
        [TestMethod]
        public void FracBecomesPositive()
        {
            string expected = "3/11";
            string actual = new MyFrac(-3, -11).ToString();
            Assert.AreEqual(expected, actual, "Constructor works wrong");
        }
    }
}