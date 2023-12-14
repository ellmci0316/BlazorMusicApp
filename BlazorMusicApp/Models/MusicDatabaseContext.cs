using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorMusicApp.Models;

public partial class MusicDatabaseContext : DbContext
{
    public MusicDatabaseContext()
    {
    }

    public MusicDatabaseContext(DbContextOptions<MusicDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Track> Tracks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("PK__Tracks__7A74F8C024A1838D");

            entity.Property(e => e.TrackId).HasColumnName("TrackID");
            entity.Property(e => e.Artist).HasMaxLength(255);
            entity.Property(e => e.Genre).HasMaxLength(255);
            entity.Property(e => e.Playlist).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
