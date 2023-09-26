using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba2_3_2;

namespace MyFracTests
{
    [TestClass]
    public class StringRepresentationTests
    {
        [TestMethod]
        public void PositiveDenominativeGreater()
        {
            string expexted = "4/15";
            string actual = new MyFrac(4, 15).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void NegativeDenominativeGreater()
        {
            string expexted = "-4/15";
            string actual = new MyFrac(-4, 15).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void PositiveInteger()
        {
            string expexted = "3";
            string actual = new MyFrac(12, 4).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void NegativeInteger()
        {
            string expexted = "-4";
            string actual = new MyFrac(-8, 2).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void PositiveIntegerAndDecimal()
        {
            string expexted = "(1+3/7)";
            string actual = new MyFrac(10, 7).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void PositiveIntegerAndDecimal2()
        {
            string expexted = "(8+1/6)";
            string actual = new MyFrac(49, 6).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void NegativeIntegerAndDecimal()
        {
            string expexted = "-(1+3/7)";
            string actual = new MyFrac(-10, 7).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
        [TestMethod]
        public void NegativeIntegerAndDecimal2()
        {
            string expexted = "-(5+4/5)";
            string actual = new MyFrac(-29, 5).ToStringWithIntegerPart();
            Assert.AreEqual(expexted, actual, "Method ToStringWithIntegerPart works wrong");
        }
    }
}
