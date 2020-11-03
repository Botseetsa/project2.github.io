using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrganisationData.Data;

[assembly: HostingStartup(typeof(OrganisationData.Areas.Identity.IdentityHostingStartup))]
namespace OrganisationData.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OrganisationDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OrganisationDataContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<OrganisationDataContext>();
            });
        }
    }
}