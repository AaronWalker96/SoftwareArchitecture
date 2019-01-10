using System;
using SignalRChat.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Threading;
using SignalRChat.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SignalRTests
{
    [TestClass()]
    public class MessagesControllerTests
    {
        //Does the Index method of the Messages controller return a view?
        [TestMethod]
        public void MessagesController_Index_ReturnsAViewResult()
        {
            // Arrange
            var optionsBuilder = new DbContextOptionsBuilder<MessagingContext>();
            var context = new MessagingContext(optionsBuilder.Options);
            var controller = new MessagesController(context);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }
    }
}
