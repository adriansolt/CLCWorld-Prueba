﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelephoneAPI.Models;

namespace TelephoneAPI.Migrations
{
    [DbContext(typeof(TelephoneContext))]
    [Migration("20190728214330_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TelephoneAPI.Models.Telephone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.HasKey("id");

                    b.ToTable("Telephones");

                    b.HasData(
                        new { id = 1, number = "612345678" },
                        new { id = 2, number = "667345698" },
                        new { id = 3, number = "668956112" },
                        new { id = 4, number = "6002546127" },
                        new { id = 5, number = "667984452" },
                        new { id = 6, number = "604571529" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
