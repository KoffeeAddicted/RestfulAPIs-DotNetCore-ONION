﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AudioAppDbContext))]
    [Migration("20240331093906_UpdateUserTable")]
    partial class UpdateUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Audio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<long>("EpisodeId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EpisodeId")
                        .IsUnique();

                    b.ToTable("Audio", "public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Duration = 0L,
                            EpisodeId = 1L,
                            IsDeleted = false,
                            Link = "123"
                        },
                        new
                        {
                            Id = 2L,
                            Duration = 0L,
                            EpisodeId = 2L,
                            IsDeleted = false,
                            Link = "456"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Episode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("OrderNumber")
                        .HasColumnType("integer");

                    b.Property<long>("StoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UpdateById")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdatedByName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Episode", "public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedById = 1L,
                            CreatedByName = "System",
                            CreatedDateTime = new DateTime(2024, 3, 31, 9, 39, 6, 300, DateTimeKind.Utc).AddTicks(2762),
                            IsDeleted = false,
                            OrderNumber = 1,
                            StoryId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreatedById = 1L,
                            CreatedByName = "System",
                            CreatedDateTime = new DateTime(2024, 3, 31, 9, 39, 6, 300, DateTimeKind.Utc).AddTicks(2767),
                            IsDeleted = false,
                            OrderNumber = 2,
                            StoryId = 1L
                        });
                });

            modelBuilder.Entity("Domain.Entities.Story", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<long>("CreatedById")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsBook")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsStory")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<double>("Rating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double precision")
                        .HasDefaultValue(0.0);

                    b.Property<string>("SourceDescription")
                        .HasColumnType("text");

                    b.Property<long>("StoryCategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("text");

                    b.Property<long?>("UpdateById")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdatedByName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Voice")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StoryCategoryId");

                    b.ToTable("Story", "public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Author = "Bí ẩn radio",
                            CreatedById = 1L,
                            CreatedByName = "System",
                            CreatedDateTime = new DateTime(2024, 3, 31, 9, 39, 6, 300, DateTimeKind.Utc).AddTicks(8131),
                            Description = "Câu chuyện về một làng chài nhỏ ở Nha Trang, nơi ẩn chứa những ký ức kinh hoàng, những khoánh khắc rùng rợn về loài ma đáng sợ: Ma da, trên những chuyến hải trình dài ngoài biển khơi....\n\nMời các bạn đón nghe chuyện ma kinh dị  (phần 1/2) của tác giả Nguyễn Quốc Huy (Huy Rùi) qua giọng đọc Tả Từ. Các bạn nên nghe bằng tai nghe để có trải nghiệm tốt nhất. Nếu cảm thấy thú vị, các bạn có thể sử dụng tính năng SuperThank (\"Cảm ơn\"), nút ở dưới các video để tặng cho MC một cốc cafe. Trân trọng!",
                            IsBook = false,
                            IsDeleted = false,
                            IsStory = true,
                            Name = "Truyện ma rợn gáy về Ma Da miền sông nước",
                            Rating = 8.5,
                            StoryCategoryId = 1L,
                            Voice = "MC tả từ"
                        });
                });

            modelBuilder.Entity("Domain.Entities.StoryCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StoryCategory", "public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsDeleted = false,
                            Name = "Kinh dị"
                        },
                        new
                        {
                            Id = 2L,
                            IsDeleted = false,
                            Name = "Hài"
                        });
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("text");

                    b.Property<string>("ProviderToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", "public");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsAdmin = false,
                            IsDeleted = false,
                            ProfilePicture = "picture.com",
                            ProviderToken = "123"
                        });
                });

            modelBuilder.Entity("Domain.Audio", b =>
                {
                    b.HasOne("Domain.Entities.Episode", "Episode")
                        .WithOne("Audio")
                        .HasForeignKey("Domain.Audio", "EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("Domain.Entities.Episode", b =>
                {
                    b.HasOne("Domain.Entities.Story", "Story")
                        .WithMany("Episodes")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("Domain.Entities.Story", b =>
                {
                    b.HasOne("Domain.Entities.StoryCategory", "StoryCategory")
                        .WithMany("Stories")
                        .HasForeignKey("StoryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoryCategory");
                });

            modelBuilder.Entity("Domain.Entities.Episode", b =>
                {
                    b.Navigation("Audio")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Story", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("Domain.Entities.StoryCategory", b =>
                {
                    b.Navigation("Stories");
                });
#pragma warning restore 612, 618
        }
    }
}
