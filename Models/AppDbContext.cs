using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<MasterDorm> MasterDormitories { get; set; }
        public virtual DbSet<MasterMenu> MasterMenus { get; set; }
        public virtual DbSet<MasterSlider> MasterSliders { get; set; }
        public virtual DbSet<MasterSocialMedium> MasterSocialMedia { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TransContactUs> TransContactUss { get; set; }
        public virtual DbSet<TransInnerDormDoubleRoom> TransInnerDormDoubleRooms { get; set; }
        public virtual DbSet<TransInnerDormNight> TransInnerDormNights { get; set; }
        public virtual DbSet<TransInnerDormTripleRoom> TransInnerDormTripleRooms { get; set; }
        public virtual DbSet<TransInternationalDormDoubleRoom> TransInternationalDormDoubleRooms { get; set; }
        public virtual DbSet<TransInternationalDormDoubleRoomSister> TransInternationalDormDoubleRoomSisters { get; set; }
        public virtual DbSet<TransInternationalDormNightRoom> TransInternationalDormNightRooms { get; set; }
        public virtual DbSet<TransInternationalDormSingleRoom> TransInternationalDormSingleRooms { get; set; }
        public virtual DbSet<TransInternationalDormTripleRoom> TransInternationalDormTripleRooms { get; set; }
    }

}

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.\\SQL2019;Initial Catalog=Peoject_2;User ID=sa;Password=123");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<MasterDorm>(entity =>
//            {
//                entity.ToTable("MasterDorm");

//                entity.Property(e => e.MasterDormId).ValueGeneratedNever();

//                entity.Property(e => e.MasterDormBrief).HasMaxLength(1000);

//                entity.Property(e => e.MasterDormImage)
//                    .HasMaxLength(1000)
//                    .IsFixedLength(true);

//                entity.Property(e => e.MasterDormLinkMap)
//                    .HasMaxLength(1000)
//                    .IsFixedLength(true);

//                entity.Property(e => e.MasterDormLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.MasterDormName).HasMaxLength(1000);
//            });

//            modelBuilder.Entity<MasterMenu>(entity =>
//            {
//                entity.ToTable("MasterMenu");

//                entity.Property(e => e.MasterMenuId).ValueGeneratedNever();

//                entity.Property(e => e.MasterMenuDropMenu)
//                    .HasMaxLength(1000)
//                    .IsFixedLength(true);

//                entity.Property(e => e.MasterMenuLinkUrl)
//                    .HasMaxLength(1000)
//                    .IsFixedLength(true);

//                entity.Property(e => e.MasterMenuName)
//                    .HasMaxLength(1000)
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<MasterSlider>(entity =>
//            {
//                entity.ToTable("MasterSlider");

//                entity.Property(e => e.MasterSliderId).ValueGeneratedNever();

//                entity.Property(e => e.MasterSliderTitle).HasMaxLength(1000);
//            });

//            modelBuilder.Entity<MasterSocialMedium>(entity =>
//            {
//                entity.HasKey(e => e.MasterSocialMediaId);

//                entity.Property(e => e.MasterSocialMediaId).ValueGeneratedNever();

//                entity.Property(e => e.MasterSocialMediaIconUrl).HasMaxLength(1000);

//                entity.Property(e => e.MasterSocialMediaLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.MasterSocialMediaName).HasMaxLength(1000);
//            });

//            modelBuilder.Entity<SystemSetting>(entity =>
//            {
//                entity.ToTable("SystemSetting");

//                entity.Property(e => e.SystemSettingId)
//                    .HasMaxLength(10)
//                    .IsFixedLength(true);

//                entity.Property(e => e.SystemSettingAmmonDorm).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingAndalusDorm).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingBriefDorm).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingBriefFooter).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingJerashDorm).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingLogoFooter).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingLogoNav).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingTitleDorm).HasMaxLength(1000);

//                entity.Property(e => e.SystemSettingZahraaDorm).HasMaxLength(1000);
//            });

//            modelBuilder.Entity<TransContactU>(entity =>
//            {
//                entity.HasKey(e => e.TransContactUsId);

//                entity.Property(e => e.TransContactUsId).ValueGeneratedNever();

//                entity.Property(e => e.TransContactLinkUrl)
//                    .HasMaxLength(10)
//                    .IsFixedLength(true);

//                entity.Property(e => e.TransContactUrlImage)
//                    .HasMaxLength(10)
//                    .IsFixedLength(true);

//                entity.Property(e => e.TransContactUsDate).HasColumnType("datetime");

//                entity.Property(e => e.TransContactUsDiscrption)
//                    .HasMaxLength(10)
//                    .IsFixedLength(true);

//                entity.Property(e => e.TransContactUsFirstName).HasMaxLength(1000);

//                entity.Property(e => e.TransContactUsLastName).HasMaxLength(1000);

//                entity.Property(e => e.TransContactUsStudentNumber).HasMaxLength(1000);

//                entity.Property(e => e.TransContactUsTitle).HasMaxLength(1000);
//            });

//            modelBuilder.Entity<TransInnerDormDoubleRoom>(entity =>
//            {
//                entity.ToTable("TransInnerDormDoubleRoom");

//                entity.Property(e => e.TransInnerDormDoubleRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAndalusDormDoubleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormDoubleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormDoubleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormDoubleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormDoubleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormDoubleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormDoubleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormDoubleRoomTitle).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInnerDormDoubleRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInnerDormDoubleRoom_MasterDorm");
//            });

//            modelBuilder.Entity<TransInnerDormNight>(entity =>
//            {
//                entity.HasKey(e => e.TransZahraaDormNightId);

//                entity.ToTable("TransInnerDormNight");

//                entity.Property(e => e.TransZahraaDormNightId).ValueGeneratedNever();

//                entity.Property(e => e.TransAndalusDormNightRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormNightRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormNightRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormNightRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormNightRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormNightRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormNightRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormNightRoomTitle).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInnerDormNights)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInnerDormNight_MasterDorm");
//            });

//            modelBuilder.Entity<TransInnerDormTripleRoom>(entity =>
//            {
//                entity.ToTable("TransInnerDormTripleRoom");

//                entity.Property(e => e.TransInnerDormTripleRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAndalusDormTripleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormTripleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormTripleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAndalusDormTripleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormTripleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormTripleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormTripleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransZahraaDormTripleRoomTitle).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInnerDormTripleRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInnerDormTripleRoom_MasterDorm");
//            });

//            modelBuilder.Entity<TransInternationalDormDoubleRoom>(entity =>
//            {
//                entity.ToTable("TransInternationalDormDoubleRoom");

//                entity.Property(e => e.TransInternationalDormDoubleRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAmmonDormDoubleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJarashDormDoubleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomLinkUrl).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInternationalDormDoubleRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInternationalDormDoubleRoom_MasterDorm");
//            });

//            modelBuilder.Entity<TransInternationalDormDoubleRoomSister>(entity =>
//            {
//                entity.HasKey(e => e.TransInternationalDormDoubleRoomSistersId);

//                entity.Property(e => e.TransInternationalDormDoubleRoomSistersId).ValueGeneratedNever();

//                entity.Property(e => e.TransAmmonDormDoubleRoomSistersBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomSistersImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomSistersLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormDoubleRoomSistersTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJarashDormDoubleRoomSistersTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomSistersBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomSistersImage).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormDoubleRoomSistersLinkUrl).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInternationalDormDoubleRoomSisters)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInternationalDormDoubleRoomSisters_MasterDorm");
//            });

//            modelBuilder.Entity<TransInternationalDormNightRoom>(entity =>
//            {
//                entity.ToTable("TransInternationalDormNightRoom");

//                entity.Property(e => e.TransInternationalDormNightRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAmmonDormNightRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormNightRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormNightRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormNightRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJarashDormNightRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormNightRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormNightRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormNightRoomLinkUrl).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInternationalDormNightRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInternationalDormNightRoom_MasterDorm");
//            });

//            modelBuilder.Entity<TransInternationalDormSingleRoom>(entity =>
//            {
//                entity.ToTable("TransInternationalDormSingleRoom");

//                entity.Property(e => e.TransInternationalDormSingleRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAmmonDormSingleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormSingleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormSingleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormSingleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJarashDormSingleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormSingleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormSingleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormSingleRoomLinkUrl).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInternationalDormSingleRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInternationalDormSingleRoom_MasterDorm");
//            });

//            modelBuilder.Entity<TransInternationalDormTripleRoom>(entity =>
//            {
//                entity.ToTable("TransInternationalDormTripleRoom");

//                entity.Property(e => e.TransInternationalDormTripleRoomId).ValueGeneratedNever();

//                entity.Property(e => e.TransAmmonDormTripleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormTripleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormTripleRoomLinkUrl).HasMaxLength(1000);

//                entity.Property(e => e.TransAmmonDormTripleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJarashDormTripleRoomTitle).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormTripleRoomBrief).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormTripleRoomImage).HasMaxLength(1000);

//                entity.Property(e => e.TransJerashDormTripleRoomLinkUrl).HasMaxLength(1000);

//                entity.HasOne(d => d.MasterDorm)
//                    .WithMany(p => p.TransInternationalDormTripleRooms)
//                    .HasForeignKey(d => d.MasterDormId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TransInternationalDormTripleRoom_MasterDorm");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
