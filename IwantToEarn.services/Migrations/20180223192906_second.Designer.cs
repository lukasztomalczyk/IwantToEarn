﻿// <auto-generated />
using IwantToEarn.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IwantToEarn.services.Migrations
{
    [DbContext(typeof(DbApplicationContext))]
    [Migration("20180223192906_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IwantToEarn.JobModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cash");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("Where");

                    b.Property<int>("WholeOrHour");

                    b.HasKey("Id");

                    b.ToTable("JobModels");
                });
#pragma warning restore 612, 618
        }
    }
}
