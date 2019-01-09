using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
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
        public async Task SendMessage(string message)
        {
            var userName = Context.User.Identity.Name;
            _context.Message.Add(new Message() { MessageText = message, SentFrom = userName });
            _context.SaveChanges();

            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}