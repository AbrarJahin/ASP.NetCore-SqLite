using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreFullTest.Model;

namespace CoreFullTest.Migrations.McpDb
{
    [DbContext(typeof(McpDbContext))]
    [Migration("20160819113606_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("CoreFullTest.Model.Bulletin", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Body");

                    b.Property<string>("Head");

                    b.HasKey("Id");

                    b.ToTable("Bulletins");
                });

            modelBuilder.Entity("CoreFullTest.Model.UserLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BulletinId");

                    b.Property<string>("device_id");

                    b.Property<string>("first_seen");

                    b.Property<int>("is_active");

                    b.Property<string>("last_seen");

                    b.HasKey("id");

                    b.HasIndex("BulletinId");

                    b.ToTable("UserLogs");
                });

            modelBuilder.Entity("CoreFullTest.Model.UserLog", b =>
                {
                    b.HasOne("CoreFullTest.Model.Bulletin")
                        .WithMany("UserLogs")
                        .HasForeignKey("BulletinId");
                });
        }
    }
}
