using Microsoft.VisualStudio.TestTools.UnitTesting;
using VPaHMI_lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPaHMI_lab3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void RomanNumberTest_1()
        {
            var number1 = new RomanNumber(0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void RomanNumberTest_2()
        {
            var number1 = new RomanNumber(4000);
        }

        [TestMethod()]
        public void CloneTest()
        {
            var number1 = new RomanNumber(13);
            RomanNumber number2 = (RomanNumber)number1.Clone();
            Assert.IsTrue(number1.CompareTo(number2) == 0);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var number = new RomanNumber(13);
            Assert.AreEqual("XIII", number.ToString());
        }

        [TestMethod]
        public void CompareToTest_Equal()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(13);
            Assert.IsTrue(number1.CompareTo(number2) == 0);
        }

        [TestMethod]
        public void CompareToTest_Greater()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(12);
            Assert.IsTrue(number1.CompareTo(number2) == 1);
        }

        [TestMethod]
        public void CompareToTest_Less()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(14);
            Assert.IsTrue(number1.CompareTo(number2) == -1);
        }

        [TestMethod]
        public void AddTest_1()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(27);
            var expected = new RomanNumber(13 + 27);
            var result = number1 + number2;

            Assert.IsTrue(expected.CompareTo(result) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void AddTest_2()
        {
            var number1 = new RomanNumber(13);
            RomanNumber? number2 = null;
            _ = number1 + number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void AddTest_3()
        {
            RomanNumber? number1 = null;
            var number2 = new RomanNumber(27);
            _ = number1 + number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void AddTest_4()
        {
            RomanNumber? number1 = null;
            RomanNumber? number2 = null;
            _ = number1 + number2;
        }

        [TestMethod]
        public void SubTest_1()
        {
            var number1 = new RomanNumber(27);
            var number2 = new RomanNumber(13);
            var expected = new RomanNumber(27 - 13);
            var result = number1 - number2;

            Assert.IsTrue(expected.CompareTo(result) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void SubTest_2()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(27);
            _ = number1 - number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void SubTest_3()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(13);
            _ = number1 - number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void SubTest_4()
        {
            var number1 = new RomanNumber(13);
            RomanNumber? number2 = null;
            _ = number1 - number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void SubTest_5()
        {
            RomanNumber? number1 = null;
            var number2 = new RomanNumber(27);
            _ = number1 - number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void SubTest_6()
        {
            RomanNumber? number1 = null;
            RomanNumber? number2 = null;
            _ = number1 - number2;
        }

        [TestMethod]
        public void MulTest_1()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(27);
            var expected = new RomanNumber(13 * 27);
            var result = number1 * number2;

            Assert.IsTrue(expected.CompareTo(result) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void MulTest_2()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(0);
            _ = number1 * number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void MulTest_3()
        {
            var number1 = new RomanNumber(13);
            RomanNumber? number2 = null;
            _ = number1 * number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void MulTest_4()
        {
            RomanNumber? number1 = null;
            var number2 = new RomanNumber(27);
            _ = number1 * number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void MulTest_5()
        {
            RomanNumber? number1 = null;
            RomanNumber? number2 = null;
            _ = number1 * number2;
        }

        [TestMethod]
        public void DivTest_1()
        {
            var number1 = new RomanNumber(27);
            var number2 = new RomanNumber(13);
            var expected = new RomanNumber(27 / 13);
            var result = number1 / number2;

            Assert.IsTrue(expected.CompareTo(result) == 0);
        }

        [TestMethod]
        public void DivTest_2()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(13);
            var expected = new RomanNumber(13 / 13);
            var result = number1 / number2;

            Assert.IsTrue(expected.CompareTo(result) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void DivTest_3()
        {
            var number1 = new RomanNumber(13);
            var number2 = new RomanNumber(0);
            _ = number1 / number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void DivTest_4()
        {
            var number1 = new RomanNumber(13);
            RomanNumber? number2 = null;
            _ = number1 / number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void DivTest_5()
        {
            RomanNumber? number1 = null;
            var number2 = new RomanNumber(27);
            _ = number1 / number2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void DivTest_6()
        {
            RomanNumber? number1 = null;
            RomanNumber? number2 = null;
            _ = number1 / number2;
        }
    }
}