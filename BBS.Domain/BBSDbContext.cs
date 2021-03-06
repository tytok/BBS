﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BBS.Domain
{
    public partial class BBSDbContext : DbContext
    {
        public BBSDbContext()
        {
        }

        public BBSDbContext(DbContextOptions<BBSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Follow> Follow { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<ThumbsUp> ThumbsUp { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicTag> TopicTag { get; set; }
        public virtual DbSet<Trail> Trail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasIndex(e => e.Account1)
                    .HasName("Account")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Account1)
                    .IsRequired()
                    .HasColumnName("Account")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Integral)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.ToTable("catalog");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(800)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.QuoteAccountId).HasColumnType("int(11)");

                entity.Property(e => e.ThumbsDownCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ThumbsUpCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TopicId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("favorite");

                entity.HasIndex(e => new { e.ItemId, e.AccountId })
                    .HasName("ItemId_AccountId")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Follow>(entity =>
            {
                entity.ToTable("follow");

                entity.HasIndex(e => new { e.AccountId, e.FollowAccountId })
                    .HasName("AccountId_FollowAccountId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FollowAccountId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tag");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnType("varchar(40)");
            });

            modelBuilder.Entity<ThumbsUp>(entity =>
            {
                entity.ToTable("thumbs_up");

                entity.HasIndex(e => new { e.ItemId, e.IsThumb, e.AccountId, e.ItemType })
                    .HasName("ItemId_IsThumb_AccountId_ItemType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsThumb).HasColumnType("bit(1)");

                entity.Property(e => e.ItemId).HasColumnType("int(11)");

                entity.Property(e => e.ItemType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("topic");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.CatalogId).HasColumnType("int(11)");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ThumbsDownCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ThumbsUpCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.TrailCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TopicTag>(entity =>
            {
                entity.ToTable("topic_tag");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TagId).HasColumnType("int(11)");

                entity.Property(e => e.TopicId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Trail>(entity =>
            {
                entity.ToTable("trail");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AccountId).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}