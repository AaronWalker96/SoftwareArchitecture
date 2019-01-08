using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalRChat.Areas.Identity.Data;

[assembly: HostingStartup(typeof(SignalRChat.Areas.Identity.IdentityHostingStartup))]

namespace SignalRChat.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        private SignalRChatIdentityDbContext _context;

        public IdentityHostingStartup(SignalRChatIdentityDbContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SignalRChatIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SignalRChatIdentityDbContextConnection")));
                System.Diagnostics.Debug.WriteLine("Got SignalRChatIdentityDbContextConnection connection string");

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<SignalRChatIdentityDbContext>();
                System.Diagnostics.Debug.WriteLine("Add Identity?");
            });
        }
    }
}