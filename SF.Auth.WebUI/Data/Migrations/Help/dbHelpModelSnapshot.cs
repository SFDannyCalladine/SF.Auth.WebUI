﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SF.Auth.DataAccess;
using System;

namespace SF.Auth.WebUI.Data.Migrations.Help
{
    [DbContext(typeof(dbHelp))]
    partial class dbHelpModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SF.Common.Help.HelpLink", b =>
                {
                    b.Property<int>("HelpLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HelpLinkID")
                        .HasColumnType("tinyint");

                    b.Property<string>("LinkText")
                        .IsRequired()
                        .HasColumnName("LinkText")
                        .HasMaxLength(255);

                    b.Property<int>("Order")
                        .HasColumnName("Order")
                        .HasColumnType("tinyint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("Url")
                        .HasMaxLength(255);

                    b.HasKey("HelpLinkId");

                    b.ToTable("HelpLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
