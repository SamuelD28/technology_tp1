using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faker;

namespace technology_tp1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<DeliveryMan> DeliveryMen { get; set; }

        public AppDbContext(){}

        public AppDbContext(DbContextOptions options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<DeliveryMan>()
                .HasData(Seed());
        }

        private DeliveryMan[] Seed()
        {
            List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
            for (int i = 0; i < 50; i++)
            {
                deliveryMen.Add(
                    new DeliveryMan(
                            i * -1,
                            NameFaker.Name(),
                            PhoneFaker.Phone(),
                            BooleanFaker.Boolean()
                        ));
            }
            return deliveryMen.ToArray();
        }
    }
}
