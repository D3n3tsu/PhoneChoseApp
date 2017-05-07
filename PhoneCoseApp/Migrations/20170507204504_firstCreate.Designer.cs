using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PhoneCoseApp.Entities;

namespace PhoneCoseApp.Migrations
{
    [DbContext(typeof(PhoneCoseAppDbContext))]
    [Migration("20170507204504_firstCreate")]
    partial class firstCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneCoseApp.Entities.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Color");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });
        }
    }
}
