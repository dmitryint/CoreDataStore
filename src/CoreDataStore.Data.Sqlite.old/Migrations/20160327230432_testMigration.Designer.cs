using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CoreDataStore.Data.Sqlite;

namespace CoreDataStore.Data.Sqlite.Migrations
{
    [DbContext(typeof(DataEventRecordContext))]
    [Migration("20160327230432_testMigration")]
    partial class testMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("CoreDataStore.Domain.Entities.DataEventRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");
                });
        }
    }
}