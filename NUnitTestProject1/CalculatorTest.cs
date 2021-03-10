using NUnit.Framework;
using File;
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
            Assert.AreEqual(Calculator.Sum(x), expectedValue);
        }
    }
}