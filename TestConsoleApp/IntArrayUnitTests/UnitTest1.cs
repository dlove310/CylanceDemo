using TestConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestConsoleApp.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void NumberToStringTestWillReturnValues()
        {
            string[] replacement = new string[2] { "fizz", "buzz" };
            int[] divisableBy = new int[2] { 3, 5 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output != null);
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesIndexZero()
        {
            string[] replacement = new string[2] { "fizz", "buzz" };
            int[] divisableBy = new int[2] { 3, 5 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[0] == "1");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesIndexTwo()
        {
            string[] replacement = new string[2] { "fizz", "buzz" };
            int[] divisableBy = new int[2] { 3, 5 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[2] == "fizz");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesIndexFour()
        {
            string[] replacement = new string[2] { "fizz", "buzz" };
            int[] divisableBy = new int[2] { 3, 5 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[4] == "buzz");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesForFifteen()
        {
            string[] replacement = new string[2] { "fizz", "buzz" };
            int[] divisableBy = new int[2] { 3, 5 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[14] == "fizz" && output[15] == "buzz");
        }


        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesNewInputIndexZero()
        {
            string[] replacement = new string[2] { "monster", "mash" };
            int[] divisableBy = new int[2] { 2, 4 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[0] == "1");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesNewInputIndexOne()
        {
            string[] replacement = new string[2] { "monster", "mash" };
            int[] divisableBy = new int[2] { 2, 4 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[1] == "monster");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesNewInputIndexThree()
        {
            string[] replacement = new string[2] { "monster", "mash" };
            int[] divisableBy = new int[2] { 2, 4 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[4] == "mash");
        }

        [TestMethod()]
        public void NumberToStringTestWillReturnCorrectValuesNewInputEight()
        {
            string[] replacement = new string[2] { "monster", "mash" };
            int[] divisableBy = new int[2] { 2, 4 };
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            Assert.IsTrue(output[8] == "monster" && output[9] == "mash");
        }
    }
}
