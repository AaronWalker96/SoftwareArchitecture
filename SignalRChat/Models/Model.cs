using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class MessagingContext : DbContext
    {
        public MessagingContext(DbContextOptions<MessagingContext> options)
            : base(options)
        { }

        public DbSet<Message> Message { get; set; }
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public string SentFrom { get; set; }
        public string SentTo { get; internal set; }
    }
}