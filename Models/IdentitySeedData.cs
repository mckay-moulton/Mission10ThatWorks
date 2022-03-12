using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "PAssword23456!";

        public static async void EnsurePopulated (IApplicationBuilder app)
        {
            AppIdentityDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDBContext>();
           if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                 .CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user ==null)
            {
                user = new IdentityUser(adminUser);

                user.Email = "admin@yeet.com";
                user.PhoneNumber = "555-12345";

                //this will create a new entry in the database with the parameters password as username
                await userManager.CreateAsync(user, adminPassword);
            }

        }
    }

}
