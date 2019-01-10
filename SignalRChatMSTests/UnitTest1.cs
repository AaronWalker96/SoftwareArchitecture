using System;
using SignalRChat.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SignalRTests
{
    public class UnitTest1
    {
        [TestMethod]
        public void CreateChatHub()
        {
            var chatHub = new ChatHub();
        }
    }
}
