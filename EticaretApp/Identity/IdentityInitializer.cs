using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EticaretApp.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EticaretApp.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roller
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){Name = "admin",Description = "admin rolü"};

                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; 

                manager.Create(role);
            }

            //user
            if (!context.Users.Any(i => i.Name == "furkanoruc"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser(){Name = "furkan", Surname = "oruc",UserName = "furkanoruc",Email = "furkanoruc18@gmail.com"};

                manager.Create(user,"furkanoruc18");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }



            if (!context.Users.Any(i => i.Name == "mehmetemin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Mehmet Emin", Surname = "Albayrak", UserName = "mehmeteminalbayrak", Email = "albmemin@gmail.com" };

                manager.Create(user, "furkanoruc18");
                
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }
    }
}