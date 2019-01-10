using System;
using SignalRChat.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Threading;

namespace SignalRTests
{
    [TestClass()]
    public class SignalRTests
    {
        //This unit test will test the creation of a SignalR chat hub. 
        [TestMethod()]
        public void CreateSignalRChatHub()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<MessagingContext>();
            var context = new MessagingContext(optionsBuilder.Options);

            // Act 
            var chatHub = new ChatHub(context);

            // Assert
            Assert.IsInstanceOfType(chatHub, typeof(ChatHub));
        }

        // TO COMPLETE - This test will FAIL as there are no clients to send a message to... I need to mockup some clients before I can add this test

        //This unit test will test sending a message, by creating a chathub and broadcasting a message
        //[TestMethod]
        //public async Task SendMessageUsingSignalRChatHub()
        //{
        //    var message = "This is a test message";
        //    var sendTo = "test@test.com";

        //    var optionsBuilder = new DbContextOptionsBuilder<MessagingContext>();
        //    var context = new MessagingContext(optionsBuilder.Options);
        //    var chatHub = new ChatHub(context);

        //    await chatHub.SendMessage(message, sendTo);
        //}
    }
}
