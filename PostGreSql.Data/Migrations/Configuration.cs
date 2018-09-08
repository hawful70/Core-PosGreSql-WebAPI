namespace PostGreSql.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PostGreSql.Data.PosGreSqlDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PostGreSql.Data.PosGreSqlDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            CreatePostCategorySample(context);
            CreateUser(context);
        }

        private void CreatePostCategorySample(PosGreSqlDbContext context)
        {
            if (context.PostCategories.Count() == 0)
            {
                List<PostCategory> listPostCategory = new List<PostCategory>()
                {
                    new PostCategory() { Name="Áo nam",Alias="ao-nam",Status=true },
                    new PostCategory() { Name="Áo nữ",Alias="ao-nu",Status=true },
                    new PostCategory() { Name="Giày nam",Alias="giay-nam",Status=true },
                    new PostCategory() { Name="Giày nữ",Alias="giay-nu",Status=true }
                };
                context.PostCategories.AddRange(listPostCategory);
                context.SaveChanges();
            }
        }

        private void CreateUser(PosGreSqlDbContext context)
        {
            var manager = new UserManager<AppUser>(new UserStore<AppUser>(new PosGreSqlDbContext()));
            if (manager.Users.Count() == 0)
            {
                var roleManager = new RoleManager<AppRole>(new RoleStore<AppRole>(new PosGreSqlDbContext()));

                var user = new AppUser()
                {
                    UserName = "admin",
                    Email = "admin@tedu.com.vn",
                    EmailConfirmed = true,
                    BirthDay = DateTime.Now,
                    FullName = "Le The hau",
                    Avatar = "/assets/images/img.jpg",
                    Gender = true,
                    Status = true
                };
                if (manager.Users.Count(x => x.UserName == "admin") == 0)
                {
                    manager.Create(user, "123654$");

                    if (!roleManager.Roles.Any())
                    {
                        roleManager.Create(new AppRole { Name = "Admin", Description = "Quản trị viên" });
                        roleManager.Create(new AppRole { Name = "Member", Description = "Người dùng" });
                    }

                    var adminUser = manager.FindByName("admin");

                    manager.AddToRoles(adminUser.Id, new string[] { "Admin", "Member" });
                }
            }
        }
    }
}
