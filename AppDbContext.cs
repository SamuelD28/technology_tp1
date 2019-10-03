﻿using Microsoft.EntityFrameworkCore;
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
                .HasData(Seed(ForgeFactory.ForgeDeliveryMan));

            modelBuilder
                .Entity<ItemImage>()
                .HasData(Seed(ForgeFactory.ForgeImageItem));

            modelBuilder
               .Entity<MenuItem>()
               .HasData(Seed(ForgeFactory.ForgeMenuItem));
        }

        private static IEnumerable<T> Seed<T>(ForgeJSONSeed<T> forge)
        {
            if (!forge.Exist)
            {
                forge.Forge();
            }

            return forge.Values;
        }
    }
}
