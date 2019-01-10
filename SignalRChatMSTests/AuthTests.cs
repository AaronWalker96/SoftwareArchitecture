using System;
using SignalRChat.Hubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Security.Principal;
using System.Threading;
using Microsoft;

namespace SignalRTests
{
    [TestClass()]
    public class AuthTests
    {
        //Add a user
        [TestMethod]
        public void AddUser()
        {
            var identity = new GenericIdentity("tugberk");
            Thread.CurrentPrincipal = new GenericPrincipal(identity, null);
        }
    }
}
