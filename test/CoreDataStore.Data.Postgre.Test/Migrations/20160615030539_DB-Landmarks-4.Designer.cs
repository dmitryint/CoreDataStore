﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreDataStore.Data.Postgre;

namespace CoreDataStore.Data.Postgre.Test.Migrations
{
    [DbContext(typeof(NYCLandmarkContext))]
    [Migration("20160615030539_DB-Landmarks-4")]
    partial class DBLandmarks4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901");

            modelBuilder.Entity("CoreDataStore.Domain.Entities.Landmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BBL");

                    b.Property<long>("BIN_NUMBER");

                    b.Property<int>("BLOCK");

                    b.Property<string>("BOUNDARIES")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("BoroughID")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 2);

                    b.Property<DateTime?>("CALEN_DATE");

                    b.Property<bool>("COUNT_BLDG");

                    b.Property<string>("DESIG_ADDR")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime?>("DESIG_DATE");

                    b.Property<string>("HIST_DISTR")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("LAST_ACTIO")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("LM_NAME")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("LM_TYPE")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 19);

                    b.Property<int>("LOT");

                    b.Property<string>("LP_NUMBER")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<bool>("MOST_CURRE");

                    b.Property<string>("NON_BLDG")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("OTHER_HEAR")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("PLUTO_ADDR")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("PUBLIC_HEA")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<bool>("SECND_BLDG");

                    b.Property<string>("STATUS")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("STATUS_NOT")
                        .HasColumnType("varchar")
                        .HasAnnotation("MaxLength", 200);

                    b.Property<bool>("VACANT_LOT");

                    b.HasKey("Id");

                    b.ToTable("Landmark");
                });

            modelBuilder.Entity("CoreDataStore.Domain.Entities.LPCReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Architect")
                        .HasColumnType("varchar");

                    b.Property<string>("Borough")
                        .HasColumnType("varchar");

                    b.Property<DateTime>("DateDesignated");

                    b.Property<string>("LPCId")
                        .HasColumnType("varchar");

                    b.Property<string>("LPNumber")
                        .HasColumnType("varchar");

                    b.Property<string>("Name");

                    b.Property<string>("ObjectType")
                        .HasColumnType("varchar");

                    b.Property<bool>("PhotoStatus");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("varchar");

                    b.Property<string>("Street");

                    b.Property<string>("Style")
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("LPCReport");
                });
        }
    }
}
