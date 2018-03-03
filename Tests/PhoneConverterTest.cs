using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Tests;

namespace Tests
{
    [TestClass]
    public class PhoneConverterTest
    {
        PhoneConverter phoneConverter = new PhoneConverter();

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void PhoneNumber_Empty_ThrowsException()
        {
            string[] elements = new[] { "", "", "", "", "", "", "" };
            phoneConverter.Convert(elements);
        }

        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void PhoneNumber_WrongFormat_ThrowsException()
        {
            string[] elements = new[] { "", "", "", "38-067-266-34-54", "", "", "" };
            phoneConverter.Convert(elements);
        }

        [TestMethod]
        public void PhoneNumber_ValidNumber_ReturnsFormattedNumber()
        {
            string[] elements = new[] { "", "", "", "380672663454", "", "", "" };
            string actual = phoneConverter.Convert(elements);
            string expected = "38(067) 266-34-54";
            Assert.AreEqual(expected, actual);
        }
    }
}
