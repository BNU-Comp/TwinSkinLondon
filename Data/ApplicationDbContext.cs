using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TwinSkinLondon.Models;

namespace TwinSkinLondon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers {get;set;}
        public DbSet<Address> Addresses{ get; set; }

        public DbSet<PaymentCard> PaymentCard { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}
