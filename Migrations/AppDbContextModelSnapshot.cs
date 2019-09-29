﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using technology_tp1.Models;

namespace technology_tp1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("technology_tp1.Models.DeliveryMan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeactivated");

                    b.Property<bool>("IsEmployed");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMen");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Joseph Peters",
                            Phone = "029-469-51535"
                        },
                        new
                        {
                            Id = -2,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Anthony Hall",
                            Phone = "185-850-66177"
                        },
                        new
                        {
                            Id = -3,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Victoria Rodriguez",
                            Phone = "961-668-43055"
                        },
                        new
                        {
                            Id = -4,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Charles Garcia",
                            Phone = "308-638-45063"
                        },
                        new
                        {
                            Id = -5,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Michelle Washington",
                            Phone = "261-838-94346"
                        },
                        new
                        {
                            Id = -6,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Edwin Williams",
                            Phone = "055-836-82695"
                        },
                        new
                        {
                            Id = -7,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Adam Dent",
                            Phone = "266-129-72743"
                        },
                        new
                        {
                            Id = -8,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Christopher Oates",
                            Phone = "392-058-09324"
                        },
                        new
                        {
                            Id = -9,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Susan Thomas",
                            Phone = "783-120-73002"
                        },
                        new
                        {
                            Id = -10,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Jennifer Yorke",
                            Phone = "041-955-80441"
                        },
                        new
                        {
                            Id = -11,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Steven Stevens",
                            Phone = "523-864-22865"
                        },
                        new
                        {
                            Id = -12,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Anthony Hall",
                            Phone = "414-320-25339"
                        },
                        new
                        {
                            Id = -13,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Nancy Brown",
                            Phone = "344-240-00848"
                        },
                        new
                        {
                            Id = -14,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Harold Abel",
                            Phone = "969-090-29673"
                        },
                        new
                        {
                            Id = -15,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Kimberly Peters",
                            Phone = "625-721-19634"
                        },
                        new
                        {
                            Id = -16,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Sarah Jackson",
                            Phone = "892-333-88701"
                        },
                        new
                        {
                            Id = -17,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Judith Abel",
                            Phone = "304-185-55097"
                        },
                        new
                        {
                            Id = -18,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Richard Kirby",
                            Phone = "851-384-46137"
                        },
                        new
                        {
                            Id = -19,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Maria Clarke",
                            Phone = "634-604-65083"
                        },
                        new
                        {
                            Id = -20,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Hugh Major",
                            Phone = "651-325-34658"
                        },
                        new
                        {
                            Id = -21,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Roger Anthony",
                            Phone = "178-923-37701"
                        },
                        new
                        {
                            Id = -22,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Jason Lewis",
                            Phone = "032-562-24462"
                        },
                        new
                        {
                            Id = -23,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Barbara Clarke",
                            Phone = "037-965-52123"
                        },
                        new
                        {
                            Id = -24,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Donald Brown",
                            Phone = "529-045-17178"
                        },
                        new
                        {
                            Id = -25,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Edwin Yorke",
                            Phone = "456-508-31804"
                        },
                        new
                        {
                            Id = -26,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "George Hall",
                            Phone = "492-300-97568"
                        },
                        new
                        {
                            Id = -27,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Beryl Smith",
                            Phone = "219-178-17222"
                        },
                        new
                        {
                            Id = -28,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Anthony Anderson",
                            Phone = "414-839-01295"
                        },
                        new
                        {
                            Id = -29,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Thomas Davidson",
                            Phone = "270-083-18552"
                        },
                        new
                        {
                            Id = -30,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Adam Taylor",
                            Phone = "076-517-16881"
                        },
                        new
                        {
                            Id = -31,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Donna Davies",
                            Phone = "017-004-01262"
                        },
                        new
                        {
                            Id = -32,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Elizabeth Brown",
                            Phone = "701-487-14740"
                        },
                        new
                        {
                            Id = -33,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Donald Peterson",
                            Phone = "346-350-40939"
                        },
                        new
                        {
                            Id = -34,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Ronald Washington",
                            Phone = "423-700-82348"
                        },
                        new
                        {
                            Id = -35,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Kimberly Yorke",
                            Phone = "389-537-55703"
                        },
                        new
                        {
                            Id = -36,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Anthony Thompson",
                            Phone = "166-898-65264"
                        },
                        new
                        {
                            Id = -37,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Terry Miller",
                            Phone = "344-901-69418"
                        },
                        new
                        {
                            Id = -38,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Michelle Oates",
                            Phone = "972-422-01516"
                        },
                        new
                        {
                            Id = -39,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Susan White",
                            Phone = "535-169-52065"
                        },
                        new
                        {
                            Id = -40,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Philip Baker",
                            Phone = "008-567-07633"
                        },
                        new
                        {
                            Id = -41,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Patricia Hall",
                            Phone = "899-555-14164"
                        },
                        new
                        {
                            Id = -42,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Robert Robinson",
                            Phone = "494-415-51225"
                        },
                        new
                        {
                            Id = -43,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Robyn Grant",
                            Phone = "765-785-75159"
                        },
                        new
                        {
                            Id = -44,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Sarah Dent",
                            Phone = "289-983-84673"
                        },
                        new
                        {
                            Id = -45,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Eve Andrews",
                            Phone = "926-897-94927"
                        },
                        new
                        {
                            Id = -46,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Terry Clarkson",
                            Phone = "982-097-69998"
                        },
                        new
                        {
                            Id = -47,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Wendy Johnson",
                            Phone = "702-157-08843"
                        },
                        new
                        {
                            Id = -48,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Patricia Clarke",
                            Phone = "965-485-57433"
                        },
                        new
                        {
                            Id = -49,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Sandra Burrows",
                            Phone = "604-557-11348"
                        });
                });

            modelBuilder.Entity("technology_tp1.Models.ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Full")
                        .IsRequired();

                    b.Property<byte[]>("Medium")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("Small")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ItemImages");
                });

            modelBuilder.Entity("technology_tp1.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImageId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("technology_tp1.Models.MenuItem", b =>
                {
                    b.HasOne("technology_tp1.Models.ItemImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
