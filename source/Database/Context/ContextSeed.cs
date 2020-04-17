using Architecture.CrossCutting;
using Architecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Architecture.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedAuths();
            builder.SeedUsers();
        }

        private static void SeedAuths(this ModelBuilder builder)
        {
            builder.Entity<Auth>(auth =>
            {
                auth.HasData(new
                {
                    Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    Login = "admin",
                    Password = "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK8=",
                    Salt = "79005744-e69a-4b09-996b-08fe0b70cbb9",
                    Roles = Roles.User | Roles.Admin
                });
            });
        }

        private static void SeedUsers(this ModelBuilder builder)
        {
            builder.Entity<User>(user =>
            {
                user.HasData(new
                {
                    Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    Status = Status.Active,
                    AuthId = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e")
                });

                user.OwnsOne(owned => owned.FullName).HasData(new
                {
                    UserId = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    Name = "Administrator",
                    Surname = "Administrator"
                });

                user.OwnsOne(owned => owned.Email).HasData(new
                {
                    UserId = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    Value = "administrator@administrator.com"
                });
            });
        }
    }
}
