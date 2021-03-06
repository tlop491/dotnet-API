﻿// <auto-generated />
using MSA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSA.Migrations
{
    [DbContext(typeof(MSAContext))]
    partial class MSAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("MSA.Models.DocumentItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName");

                    b.Property<string>("Height");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.Property<string>("TypeDoc");

                    b.Property<string>("Uploaded");

                    b.Property<string>("Url");

                    b.Property<string>("UserId");

                    b.Property<string>("Width");

                    b.HasKey("Id");

                    b.ToTable("DocumentItem");
                });
#pragma warning restore 612, 618
        }
    }
}
