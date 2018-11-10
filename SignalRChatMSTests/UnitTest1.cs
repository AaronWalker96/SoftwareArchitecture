using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SignalRChatMSTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnePlusOneEqualsTwo()
        {
            Assert.AreEqual(2, (1+1));
        }
        [TestMethod]
        public void TwoPlusTwoEqualsFour()
        {
            Assert.AreEqual(4, (2 + 2));
        }
    }
}
