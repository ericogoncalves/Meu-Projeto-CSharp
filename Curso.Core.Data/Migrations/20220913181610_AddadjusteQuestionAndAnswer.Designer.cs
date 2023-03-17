﻿// <auto-generated />
using System;
using Curso.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Curso.Core.Data.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20220913181610_AddadjusteQuestionAndAnswer")]
    partial class AddadjusteQuestionAndAnswer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Curso.Core.Model.DataModels.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PermitionAccessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PermitionAccessId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.CustomerVideo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsViewed")
                        .HasColumnType("bit");

                    b.Property<Guid>("PermitionAccessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VideoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermitionAccessId");

                    b.HasIndex("VideoId");

                    b.ToTable("CustomerVideos");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.FileData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FileData");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.PermitionAccess", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PermitionAccesses");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("PermitionAccessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PermitionAccessId");

                    b.ToTable("Querys");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsViewed")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.Answer", b =>
                {
                    b.HasOne("Curso.Core.Model.DataModels.PermitionAccess", "PermitionAccess")
                        .WithMany("Answers")
                        .HasForeignKey("PermitionAccessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Curso.Core.Model.DataModels.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("PermitionAccess");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.CustomerVideo", b =>
                {
                    b.HasOne("Curso.Core.Model.DataModels.PermitionAccess", "PermitionAccess")
                        .WithMany("CustomerVideos")
                        .HasForeignKey("PermitionAccessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Curso.Core.Model.DataModels.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermitionAccess");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.Question", b =>
                {
                    b.HasOne("Curso.Core.Model.DataModels.PermitionAccess", "PermitionAccess")
                        .WithMany("Questions")
                        .HasForeignKey("PermitionAccessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermitionAccess");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.PermitionAccess", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("CustomerVideos");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Curso.Core.Model.DataModels.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
