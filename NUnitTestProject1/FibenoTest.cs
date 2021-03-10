using NUnit.Framework;
using File;
namespace NUnitTestProject1
{
    public class FibenoTest
    {
        [Test]
        public void FibenoNumberstest()
        {
            Assert.AreEqual(Calculator.Sum(0, 0), 0,1e-4);
            Assert.AreEqual(Calculator.Sum(0, 1), 1, 1e-4);
        }
    }
}