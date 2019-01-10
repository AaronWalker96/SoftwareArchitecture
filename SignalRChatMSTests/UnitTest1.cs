using System;
using SignalRChat.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SignalRTests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void CreateChatHub()
        {
            var chatHub = new ChatHub();
        }
    }
}
