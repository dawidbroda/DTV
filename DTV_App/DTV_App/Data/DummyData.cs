using DTV_App.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> UserManager, RoleManager<ApplicationRole> RoleManager)
        {
            context.Database.EnsureCreated();

            String AdmimId1 = "";
            String AdmimId2 = "";

            string Role1 = "Admin";
            string Desc1 = "To jest rola Administrator.";

            string Role2 = "Użytkownik";
            string Desc2 = "To jest rola Użytkownika.";

            string Password = "Dawid123!";

            if(await RoleManager.FindByNameAsync(Role1) == null)
            {
                await RoleManager.CreateAsync(new ApplicationRole(Role1, Desc1, DateTime.Now));
            }
            if (await RoleManager.FindByNameAsync(Role2) == null)
            {
                await RoleManager.CreateAsync(new ApplicationRole(Role2, Desc2, DateTime.Now));
            }

            if (await UserManager.FindByNameAsync("dawidbroda92@gmail.com") == null)
            {
                var User = new ApplicationUser
                {
                    Login = "Azyl",
                    Email = "dawidbroda92@gmail.com"
                };

                var result = await UserManager.CreateAsync(User);

                if(result.Succeeded)
                {
                    await UserManager.AddPasswordAsync(User, Password);
                    await UserManager.AddToRoleAsync(User, Role1);
                }
            }
        }
    }
}
