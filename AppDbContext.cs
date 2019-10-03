using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1.Models
{
    public class AppDbContext : DbContext
    {
        private static string SeedDirectoryPath = "Seeds/";
        private static string FileNameSeedDeliveryMan = "DeliveryManSeed.json";


        public DbSet<DeliveryMan> DeliveryMen { get; set; }

        public DbSet<ItemImage> ItemImages { get; set; }

        public DbSet<MenuItem> MenuItems{ get; set; }

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
            ForgeJSONSeed forge = new ForgeJSONSeedDeliveryMan();
            if (!forge.Exist)
            {
                forge.Forge();
            }

            List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
            foreach (var item in forge.JToken)
            {
                JObject jsonItem = (JObject)item;
                deliveryMen.Add(new DeliveryMan()
                {
                    Id = jsonItem.Value<int>("id"),
                    Name = jsonItem.Value<string>("name"),
                    Phone = jsonItem.Value<string>("phone"),
                    IsEmployed = jsonItem.Value<bool>("isEmployed"),
                });
            }
            return deliveryMen.ToArray();
        }
    }
}
