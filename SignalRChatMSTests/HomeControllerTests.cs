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
    public class HomeControllerTests
    {
        //Does the index method of the home controller return a view?
        [TestMethod]
        public void HomeController_Index_ReturnsAViewResult ()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        //Does the history method of the home controller return a view?
        [TestMethod]
        public void HomeController_History_ReturnsAViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.History();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
