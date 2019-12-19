using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace AisMKIT.Models
{

    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            // логин и пароль для администратора, создаётся при запуске программы
            string adminEmail = "admin@aismkit.kg";
            string password = "QWErty1!";

            // Создание ролей 
            // роль Администратор
            if (await roleManager.FindByNameAsync("Супер-Администратор") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Супер-Администратор"));
            }

            // роль Редактор
            if (await roleManager.FindByNameAsync("Редактор") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Редактор"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                // создание пользователья
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                
                IdentityResult result = await userManager.CreateAsync(admin, password);
                
                if (result.Succeeded)
                {
                    // добавление роли для пользователья
                    await userManager.AddToRoleAsync(admin, "Супер-Администратор");
                }
            }
        }
    }
}
