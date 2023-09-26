using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba2_3_2;

namespace MyFracTests
{
    [TestClass]
    public class SequenceTests
    {
        [TestMethod]
        public void CalcSum11()
        {
            string expected = new MyFrac(1,2).ToString();
            string actual = MyFrac.CalcSum1(1).ToString();
            Assert.AreEqual(expected, actual, "CalcSum1 method doen't work right");
        }
        [TestMethod]
        public void CalcSum15()
        {
            string expected = new MyFrac(5, 6).ToString();
            string actual = MyFrac.CalcSum1(5).ToString();
            Assert.AreEqual(expected, actual, "CalcSum1 method doen't work right");
        }
        [TestMethod]
        public void CalcSum110()
        {
            string expected = new MyFrac(10, 11).ToString();
            string actual = MyFrac.CalcSum1(10).ToString();
            Assert.AreEqual(expected, actual, "CalcSum1 method doen't work right");
        }
        [TestMethod]
        public void CalcSum115()
        {
            string expected = new MyFrac(15, 16).ToString();
            string actual = MyFrac.CalcSum1(15).ToString();
            Assert.AreEqual(expected, actual, "CalcSum1 method doen't work right");
        }
        [TestMethod]
        public void CalcSum130()
        {
            string expected = new MyFrac(30, 31).ToString();
            string actual = MyFrac.CalcSum1(30).ToString();
            Assert.AreEqual(expected, actual, "CalcSum1 method doen't work right");
        }
        [TestMethod]
        public void CalcSum21()
        {
            string expected = new MyFrac(1, 1).ToString();
            string actual = MyFrac.CalcSum2(1).ToString();
            Assert.AreEqual(expected, actual, "CalcSum2 method doen't work right");
        }
        [TestMethod]
        public void CalcSum25()
        {
            string expected = new MyFrac(3, 5).ToString();
            string actual = MyFrac.CalcSum2(5).ToString();
            Assert.AreEqual(expected, actual, "CalcSum2 method doen't work right");
        }
        [TestMethod]
        public void CalcSum210()
        {
            string expected = new MyFrac(11, 20).ToString();
            string actual = MyFrac.CalcSum2(10).ToString();
            Assert.AreEqual(expected, actual, "CalcSum2 method doen't work right");
        }
        [TestMethod]
        public void CalcSum215()
        {
            string expected = new MyFrac(8, 15).ToString();
            string actual = MyFrac.CalcSum2(15).ToString();
            Assert.AreEqual(expected, actual, "CalcSum2 method doen't work right");
        }
        [TestMethod]
        public void CalcSum230()
        {
            string expected = new MyFrac(31, 60).ToString();
            string actual = MyFrac.CalcSum2(30).ToString();
            Assert.AreEqual(expected, actual, "CalcSum2 method doen't work right");
        }
    }
}
