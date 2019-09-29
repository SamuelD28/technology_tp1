﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using technology_tp1.Models;

namespace technology_tp1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190929233743_added_order_ordermenuitems")]
    partial class added_order_ordermenuitems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            IsEmployed = true,
                            Name = "Ursula Jackson",
                            Phone = "572-319-51750"
                        },
                        new
                        {
                            Id = -2,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Betty Jefferson",
                            Phone = "345-564-09244"
                        },
                        new
                        {
                            Id = -3,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Roger Martin",
                            Phone = "416-881-96502"
                        },
                        new
                        {
                            Id = -4,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Michelle Dent",
                            Phone = "976-305-33394"
                        },
                        new
                        {
                            Id = -5,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Sharon Oates",
                            Phone = "753-109-26324"
                        },
                        new
                        {
                            Id = -6,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Jennifer Jeffries",
                            Phone = "342-057-56801"
                        },
                        new
                        {
                            Id = -7,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Simon Jackson",
                            Phone = "307-936-74636"
                        },
                        new
                        {
                            Id = -8,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Arthur Major",
                            Phone = "739-969-59391"
                        },
                        new
                        {
                            Id = -9,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Betty Yorke",
                            Phone = "187-993-00066"
                        },
                        new
                        {
                            Id = -10,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Michelle Taylor",
                            Phone = "616-237-84247"
                        },
                        new
                        {
                            Id = -11,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Adam Davidson",
                            Phone = "813-618-34126"
                        },
                        new
                        {
                            Id = -12,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Deborah Wilson",
                            Phone = "992-520-23822"
                        },
                        new
                        {
                            Id = -13,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "John Burrows",
                            Phone = "260-884-79403"
                        },
                        new
                        {
                            Id = -14,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Thomas Moore",
                            Phone = "401-258-98716"
                        },
                        new
                        {
                            Id = -15,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Felicity White",
                            Phone = "389-000-29341"
                        },
                        new
                        {
                            Id = -16,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Laura Walker",
                            Phone = "373-182-22923"
                        },
                        new
                        {
                            Id = -17,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Paul Davis",
                            Phone = "626-565-84952"
                        },
                        new
                        {
                            Id = -18,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Ruth Harris",
                            Phone = "923-888-43560"
                        },
                        new
                        {
                            Id = -19,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Patricia Robinson",
                            Phone = "292-189-31934"
                        },
                        new
                        {
                            Id = -20,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Kevin Major",
                            Phone = "143-630-43831"
                        },
                        new
                        {
                            Id = -21,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Simon Lewis",
                            Phone = "986-232-86945"
                        },
                        new
                        {
                            Id = -22,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Joseph Jackson",
                            Phone = "407-956-22368"
                        },
                        new
                        {
                            Id = -23,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Richard Robertson",
                            Phone = "022-346-62233"
                        },
                        new
                        {
                            Id = -24,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Donald Smythe",
                            Phone = "008-490-11396"
                        },
                        new
                        {
                            Id = -25,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Kevin Kirby",
                            Phone = "638-233-70078"
                        },
                        new
                        {
                            Id = -26,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Kevin Burrows",
                            Phone = "770-557-69868"
                        },
                        new
                        {
                            Id = -27,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Helena Rodriguez",
                            Phone = "036-770-92842"
                        },
                        new
                        {
                            Id = -28,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Michelle Baker",
                            Phone = "265-219-57079"
                        },
                        new
                        {
                            Id = -29,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Lisa Kirby",
                            Phone = "186-374-26817"
                        },
                        new
                        {
                            Id = -30,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Brian Grant",
                            Phone = "782-731-66285"
                        },
                        new
                        {
                            Id = -31,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Anne Robinson",
                            Phone = "506-333-44960"
                        },
                        new
                        {
                            Id = -32,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Beryl Jeffries",
                            Phone = "336-790-12225"
                        },
                        new
                        {
                            Id = -33,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Joseph Davidson",
                            Phone = "855-157-97793"
                        },
                        new
                        {
                            Id = -34,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Christopher Hall",
                            Phone = "195-841-09064"
                        },
                        new
                        {
                            Id = -35,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Brian Stevens",
                            Phone = "109-784-45564"
                        },
                        new
                        {
                            Id = -36,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Robyn Oates",
                            Phone = "690-915-75107"
                        },
                        new
                        {
                            Id = -37,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Joseph Clark",
                            Phone = "956-972-44387"
                        },
                        new
                        {
                            Id = -38,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Cheryl White",
                            Phone = "611-494-74924"
                        },
                        new
                        {
                            Id = -39,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Polly Abel",
                            Phone = "790-469-89031"
                        },
                        new
                        {
                            Id = -40,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Anne Jeffries",
                            Phone = "183-136-50562"
                        },
                        new
                        {
                            Id = -41,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Nancy Harrison",
                            Phone = "766-307-44597"
                        },
                        new
                        {
                            Id = -42,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Brian Smith",
                            Phone = "903-506-16432"
                        },
                        new
                        {
                            Id = -43,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Robert Kirk",
                            Phone = "811-655-83967"
                        },
                        new
                        {
                            Id = -44,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Charlotte Martinez",
                            Phone = "349-761-71676"
                        },
                        new
                        {
                            Id = -45,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Thomas Thompson",
                            Phone = "896-016-04521"
                        },
                        new
                        {
                            Id = -46,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Terry Grant",
                            Phone = "234-807-96131"
                        },
                        new
                        {
                            Id = -47,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Tabitha Wilson",
                            Phone = "553-087-68092"
                        },
                        new
                        {
                            Id = -48,
                            IsDeactivated = false,
                            IsEmployed = false,
                            Name = "Kevin Kirk",
                            Phone = "432-342-54918"
                        },
                        new
                        {
                            Id = -49,
                            IsDeactivated = false,
                            IsEmployed = true,
                            Name = "Mary Abel",
                            Phone = "655-566-23155"
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

                    b.Property<double>("Price");

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
