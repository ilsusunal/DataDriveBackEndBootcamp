using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData{
    public static void CreateTestData(IApplicationBuilder app){
        var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext> ();
        if(context != null){
            if(context.Database.GetPendingMigrations().Any()){
                context.Database.Migrate();
            }
            if(!context.Tags.Any()){
                context.Tags.AddRange(
                    new Entity.Tag{Text = "back-end"},
                    new Entity.Tag{Text = "front-end"},
                    new Entity.Tag{Text = "game-dev"},
                    new Entity.Tag{Text = "full-stack"}
                );
                context.SaveChanges();
            }
            if(!context.Users.Any()){
                context.Users.AddRange(
                    new Entity.User{UserName = "ilsusunal"},
                    new Entity.User{UserName = "ahmetkaya"},
                    new Entity.User{UserName = "selinkarsli"},
                    new Entity.User{UserName = "alidemir"}
                );
                context.SaveChanges();
            }
            if(!context.Posts.Any()){
                context.Posts.AddRange(
                    new Entity.Post{
                        Title = "ASP.NET Core Introduction",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        PublishedOn = DateTime.Now.AddDays(-10),
                        IsPublished = true,
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 1},
                    new Entity.Post{
                        Title = "Modern Javascript Frameworks",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        PublishedOn = DateTime.Now.AddDays(-5),
                        IsPublished = true,
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 2},
                    new Entity.Post{
                        Title = "Basic Metrodivania Game With Unity",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        PublishedOn = DateTime.Now.AddDays(-3),
                        IsPublished = true,
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 3}
                        
                );
                context.SaveChanges();
            }
        }
    }
    }
}