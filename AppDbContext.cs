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
            if (!File.Exists(SeedDirectoryPath + FileNameSeedDeliveryMan))
            {
                createJSONSeedDeliveryMan();
            }

            JArray jObject;
            using (StreamReader streamReader = System.IO.File.OpenText(SeedDirectoryPath + FileNameSeedDeliveryMan))
            using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
            {
                jObject = (JArray)JToken.ReadFrom(jsonTextReader);
            }

            List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
            foreach (var item in jObject)
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

        private static void createJSONSeedDeliveryMan()
        {
            JArray jArray = new JArray();
            for (int i = 1; i < 50; i++)
            {
                JObject deliveryMan = new JObject();
                deliveryMan.Add("id", new JValue(i * -1));
                deliveryMan.Add("name", new JValue(Faker.NameFaker.Name()));
                deliveryMan.Add("phone", new JValue(Faker.PhoneFaker.Phone()));
                deliveryMan.Add("isEmployed", new JValue(Faker.BooleanFaker.Boolean()));
                jArray.Add(deliveryMan);
            }

            using (StreamWriter streamWriter = new StreamWriter(System.IO.File.OpenWrite(SeedDirectoryPath + FileNameSeedDeliveryMan)))
            using (JsonTextWriter jsonTextReader = new JsonTextWriter(streamWriter))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(jsonTextReader, jArray);
            }
        }
    }
}
