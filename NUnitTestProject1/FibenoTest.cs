using NUnit.Framework;
using File;
namespace NUnitTestProject1
{
    public class FibenoTest
    {
        [Test, Sequential]
        public void FibenoNumberstest(
            [Values(0, 1, 1)]double x,
            [Values(0, 0, 1)] double y,
            [Values(0, 1, 2)] double expectedValue
            )
        {
            Assert.AreEqual(Calculator.Sum(x, y), expectedValue,1e-4);
        }
    }
}