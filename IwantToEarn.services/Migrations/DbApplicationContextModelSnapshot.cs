﻿// <auto-generated />
using IwantToEarn.services.DbModel;
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
    partial class DbApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IwantToEarn.services.DbModel.JobModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Cash")
                        .HasColumnName("Cash")
                        .HasColumnType("money");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("ntext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("JobTitle")
                        .HasColumnType("nchar(20)")
                        .HasMaxLength(25);

                    b.Property<string>("Where")
                        .IsRequired()
                        .HasColumnName("WhereIsJob")
                        .HasColumnType("nchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("WholeOrHour")
                        .HasColumnName("ForHourOrWholeJob")
                        .HasColumnType("bit")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("JobModels");
                });
#pragma warning restore 612, 618
        }
    }
}
