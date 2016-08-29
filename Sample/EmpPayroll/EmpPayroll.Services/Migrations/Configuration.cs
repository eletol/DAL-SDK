using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using EmpPayroll.Services.Domain.Models;
using EmpPayroll.Services.Models;
using Microsoft.AspNet.Identity;

namespace EmpPayroll.Services.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var guid1 = Guid.NewGuid().ToString();
            var guid2 = Guid.NewGuid().ToString();
            var guid3 = Guid.NewGuid().ToString();
            var user = new ApplicationUser() { UserName = "ahmed.eletol@gmail.com", Email = "ahmed.eletol@gmail.com" };
            var dep = new Department { Name = "dep1", DId = guid1 };

            context.Departments.AddOrUpdate(
                dep
                );

            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("Password@123");
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "Steve@Steve.com",
                    Email = "Steve@Steve.com",
                    Salary = 1000,
                    PasswordHash = password,
                    PhoneNumber = "08869879",
                    DId= guid1,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Id = guid2
                    
                },
            
                 new ApplicationUser
                 {
                     UserName = "Ahmed@Ahmed.com",
                     Email = "Ahmed@Ahmed.com",
                     Salary = 1000,
                     PasswordHash = password,
                     PhoneNumber = "0886944879",
                     DId = guid1,
                     SecurityStamp = Guid.NewGuid().ToString(),
                     Id = guid3

                 },
                 new ApplicationUser
                 {
                     UserName = "Ahmed2@Ahmed.com",
                     Email = "Ahmed2@Ahmed.com",
                     Salary = 1000,
                     PasswordHash = password,
                     PhoneNumber = "088677944879",
                     DId = guid1,
                     SecurityStamp = Guid.NewGuid().ToString(),
                     Id = Guid.NewGuid().ToString()

                 });
            context.Mangers.AddOrUpdate(
                     new Manger() { DId = guid1, UserId = guid2 }
                     );
            /*      
                    context.Users.AddOrUpdate(
                        new ApplicationUser
                        {
                            UserName = "usere",
                            PasswordHash = "P@ssw0rd",
                            Email = "sd@gh.df",
                            DId = guid1,
                            Id = guid2
                        },
                        new ApplicationUser
                        {
                            UserName = "userf",
                            PasswordHash = "P@ssw0rd",
                            Email = "sd@gh.df",
                            DId = guid1,
                            Id = guid3
                        }
                        );
                    context.Mangers.AddOrUpdate(
                        new Manger() { DId = guid1, UserId = guid2 }
                        );*/

            //
        }
  
     
    }
}