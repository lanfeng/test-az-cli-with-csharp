using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum;

namespace SumUT
{
    [TestClass]
    public class TestCal
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(3, Calculation.Sum(1, 2));
        }
    }
}
