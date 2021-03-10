using NUnit.Framework;
using File;
using System;

namespace NUnitTestProject1
{
    public class CalculatorTest
    {
        [Test,Sequential]
        public void TestCalculator(
            [Values("", "1", "2","1,2")] string x,
            [Values(0, 1, 2, 3)] int expectedValue
            )
        {
            Assert.AreEqual(Calculator.Add(x), expectedValue);
        }

        [Test, Sequential]
        public void Multiple(
            [Values("", "1", "2", "1,2", "1,2,3,4")] string x,
            [Values(0, 1, 2, 3, 10)] int expectedValue
            )
        {
            Assert.AreEqual(Calculator.Add(x), expectedValue);
        }
        [Test, Sequential]
        public void add_newLine(
            [Values("", "1", "2", "1\n2,3", "1\n2")] string x,
            [Values(0, 1, 2, 6, 3)] int expectedValue
            )
        {
            Assert.AreEqual(Calculator.Add(x), expectedValue);
        }

        [Test, Sequential]
        public void add_negative(
          [Values("-1")] string x
          )
        {
            TestDelegate add = () => Calculator.Add(x);
            Assert.Throws<Exception>(add);
}
        [Test, Sequential]
        public void add_changedeliminator(
           [Values("", "1", "2", "//;n1;2")] string x,
           [Values(0, 1, 2, 3)] int expectedValue
           )
        {
            Assert.AreEqual(Calculator.Add(x), expectedValue);
        }


    }
}