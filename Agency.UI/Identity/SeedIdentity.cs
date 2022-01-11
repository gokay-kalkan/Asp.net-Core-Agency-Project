using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            var username = configuration["Data:AdminUser:username"];
            var email = configuration["Data:AdminUser:email"];
            var password = configuration["Data:AdminUser:password"];
            var role = configuration["Data:AdminUser:role"];
            if (await userManager.FindByNameAsync(username) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new AppUser()
                {
                    UserName = username,
                    Email = email,
                    FullName = "GökayAdmin"

                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }

          public static void Seed2(UserManager<AppUser>userManager, RoleManager<IdentityRole> roleManager)
        {
            var user = new AppUser()
            {
                UserName = "Mamo",
                Email = "mamo@gmail.com",
                FullName = "Mahmut Can"

            };
            if (userManager.FindByNameAsync("Mahmut Can").Result==null)
            {

                var identtiyResult = userManager.CreateAsync(user,"123456").Result;
            }
            if (roleManager.FindByNameAsync("Editor").Result==null)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = "Editor"
                };
                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(user, role.Name).Result;
            }
        }


        public static void Seed3(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var user = new AppUser()
            {
                UserName = "Levent",
                Email = "levent@gmail.com",
                FullName = "Levent Can"

            };
            if (userManager.FindByNameAsync("Levent Can").Result == null)
            {

                var identtiyResult = userManager.CreateAsync(user, "123456").Result;
            }
            if (roleManager.FindByNameAsync("Moderatör").Result == null)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = "Moderatör"
                };
                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(user, role.Name).Result;
            }
        }

    }
}
