using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private MessagingContext _context;
        private static ConcurrentDictionary<string, string> clients = new ConcurrentDictionary<string, string>();

        public ChatHub(MessagingContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task SendMessage(string message, string sentTo)
        {
            var userName = Context.User.Identity.Name;
            _context.Message.Add(new Message() { MessageText = message, SentFrom = userName, SentTo = sentTo });
            _context.SaveChanges();

            await Clients.All.SendAsync("ReceiveMessage", userName, message);
            //await Clients.User("aaron@test.com").SendAsync("ReceiveMessage", userName, message);
        }
    }
}