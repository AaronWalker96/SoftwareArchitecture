using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace SignalRChat.Controllers
{
    public class MessagesController : Controller
    {
        private readonly MessagingContext _context;

        public MessagesController(MessagingContext context)
        {
            _context = context; 
        }

        // GET: Messages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Message.ToListAsync());
        }

        private bool MessageExists(int id)
        {
            return _context.Message.Any(e => e.MessageId == id);
        }
    }
}
