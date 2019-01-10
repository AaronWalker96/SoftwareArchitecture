using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private MessagingContext _context;

        public ChatHub(MessagingContext context)
        {
                _context = context;
        }

        [Authorize]
        public async Task SendMessage(string message, string sentTo)
        {
            string userName = "Unavailable";
            try
            {
                userName = Context.User.Identity.Name;
                _context.Message.Add(new Message() { MessageText = message, SentFrom = userName, SentTo = sentTo });
                _context.SaveChanges();
            }
            catch (System.NullReferenceException)
            {
                userName = "Unavailable";
            }
            try
            {
                await Clients.All.SendAsync("ReceiveMessage", userName, message);
            }
            catch(SystemException)
            {
                Console.WriteLine("This failed");
            }
        }

        [Authorize]
        public string ForUnitTest()
        {
            //Can I access this method even though it says [Authorize]?
            return "test";
        }
    }
}