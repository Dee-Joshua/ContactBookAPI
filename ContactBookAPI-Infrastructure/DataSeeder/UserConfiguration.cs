using ContactBookAPI_Domain.Enums;
using ContactBookAPI_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactBookAPI_Infrastructure.DataSeeder
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                new User
                {
                    Id = "8A876943-04F7-4C83-99D2-C7B3871625C1",
                    FullName = "Admin User",
                    Email = "admin@example.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin_password"),
                },
                new User
                {
                    Id = "1A4399FF-DB49-45F9-949F-182E43020DD6",
                    FullName = "Regular User",
                    Email = "user1@example.com",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("hashed_password"),
                }
                );
        }
    }
}
