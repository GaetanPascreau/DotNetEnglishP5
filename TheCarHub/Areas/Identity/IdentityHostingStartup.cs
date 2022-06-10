using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheCarHub.Areas.Identity.Data;
using TheCarHub.Data;

[assembly: HostingStartup(typeof(TheCarHub.Areas.Identity.IdentityHostingStartup))]
namespace TheCarHub.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TheCarHubContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TheCarHubContextConnection")));

                services.AddDefaultIdentity<TheCarHubUser>()
                    .AddEntityFrameworkStores<TheCarHubContext>();
            });
        }
    }
}