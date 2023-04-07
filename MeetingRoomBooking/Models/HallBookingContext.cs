using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoomBooking.Models;

public partial class HallBookingContext : DbContext
{
    public HallBookingContext()
    {
    }

    public HallBookingContext(DbContextOptions<HallBookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MeetingtHall> MeetingtHalls { get; set; }

    public virtual DbSet<RoomWiseDayTime> RoomWiseDayTimes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MeetingtHall>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("MeetingtHall");

            entity.Property(e => e.HallName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomWiseDayTime>(entity =>
        {
            entity.HasKey(e => e.RoomDayTimeId).HasName("PK__RoomWise__FCAAE939AF223BD2");

            entity.ToTable("RoomWiseDayTime");

            entity.Property(e => e.FriEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FriStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Frirange).IsUnicode(false);
            entity.Property(e => e.MonEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MonStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Monrange).IsUnicode(false);
            entity.Property(e => e.SatEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SatStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Satrange).IsUnicode(false);
            entity.Property(e => e.SunEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SunStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Sunrange).IsUnicode(false);
            entity.Property(e => e.ThuEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ThuStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Thurange).IsUnicode(false);
            entity.Property(e => e.TueEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TueStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Tuerange).IsUnicode(false);
            entity.Property(e => e.WedEndTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.WedStartTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Wedrange).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
