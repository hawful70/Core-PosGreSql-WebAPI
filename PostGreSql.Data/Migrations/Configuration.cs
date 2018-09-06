namespace PostGreSql.Data.Migrations
{
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
    }
}
