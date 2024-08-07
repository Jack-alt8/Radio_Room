﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Radio_Room.UI.dbContext;

#nullable disable

namespace Radio_Room.Data.Migrations
{
    [DbContext(typeof(Radio_RoomDbContext))]
    [Migration("20240612134757_First Commit")]
    partial class FirstCommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Radio_Room.Domain.Dialogue", b =>
                {
                    b.Property<int>("DialogueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DialogueLine")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DialogueId");

                    b.ToTable("dialogues");
                });
#pragma warning restore 612, 618
        }
    }
}
