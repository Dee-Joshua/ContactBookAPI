using ContactBookAPI_Domain.Enums;
using ContactBookAPI_Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI_Infrastructure.DataSeeder
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData
                (
                new Contact 
                { 
                    Id = "548ADC28-0DF9-4A13-BA57-07CEAB06C760",
                    FirstName = "John", 
                    LastName = "Doe", 
                    PhoneNumber = "1234567890", 
                    Email = "john@example.com", 
                    Address = "123 Main St", 
                    UserId = "8A876943-04F7-4C83-99D2-C7B3871625C1"
                },
                new Contact 
                { 
                    Id = "D74D6FE0-AE65-4AF6-8355-E3C2E10AABC8",
                    FirstName = "Jane", 
                    LastName = "Smith", 
                    PhoneNumber = "9876543210",
                    Email = "jane@example.com", 
                    Address = "456 Elm St", 
                    UserId = "1A4399FF-DB49-45F9-949F-182E43020DD6"
                }
                );
        }
    }
}
