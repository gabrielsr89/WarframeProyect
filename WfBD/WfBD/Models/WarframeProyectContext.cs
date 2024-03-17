using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WfBD.Models;

public partial class WarframeProyectContext : DbContext
{
    public WarframeProyectContext()
    {
    }

    public WarframeProyectContext(DbContextOptions<WarframeProyectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Object> Objects { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<ResourcesZoneObject> ResourcesZoneObjects { get; set; }

    public virtual DbSet<Tier> Tiers { get; set; }

    public virtual DbSet<TypeObject> TypeObjects { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-P0N0H6H\\SQLEXPRESS2019;Database=WarframeProyect;Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Object>(entity =>
        {
            entity.HasKey(e => e.ObjectId).HasName("PK__object__3DC088B52644416A");

            entity.ToTable("object");

            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.Object1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("object");
            entity.Property(e => e.TypeObjectId).HasColumnName("type_object_id");
            entity.Property(e => e.Vault).HasColumnName("vault");

            entity.HasOne(d => d.TypeObject).WithMany(p => p.Objects)
                .HasForeignKey(d => d.TypeObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_typeobject_object");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.ResourceId).HasName("PK__resource__4985FC73D5321083");

            entity.ToTable("resource");

            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.Resource1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("resource");
        });

        modelBuilder.Entity<ResourcesZoneObject>(entity =>
        {
            entity.HasKey(e => e.ResourcesZoneObject1).HasName("PK__resource__884AED856737789D");

            entity.ToTable("resources_zone_object");

            entity.Property(e => e.ResourcesZoneObject1).HasColumnName("resources_zone_object");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.TierId).HasColumnName("tier_id");
            entity.Property(e => e.ZoneId).HasColumnName("zone_id");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourcesZoneObjects)
                .HasForeignKey(d => d.ResourceId)
                .HasConstraintName("fk_resource_resourcesZoneObject");

            entity.HasOne(d => d.Tier).WithMany(p => p.ResourcesZoneObjects)
                .HasForeignKey(d => d.TierId)
                .HasConstraintName("fk_tier_tresourcesZoneObject");

            entity.HasOne(d => d.Zone).WithMany(p => p.ResourcesZoneObjects)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("fk_zone_resourcesZoneObject");
        });

        modelBuilder.Entity<Tier>(entity =>
        {
            entity.HasKey(e => e.TierId).HasName("PK__tier__9D52AF9C21F7CAF0");

            entity.ToTable("tier");

            entity.Property(e => e.TierId).HasColumnName("tier_id");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Tier1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tier");
        });

        modelBuilder.Entity<TypeObject>(entity =>
        {
            entity.HasKey(e => e.TypeObjectId).HasName("PK__type_obj__AFE737F0C91ED208");

            entity.ToTable("type_object");

            entity.Property(e => e.TypeObjectId).HasColumnName("type_object_id");
            entity.Property(e => e.TypeObject1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type_object");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PK__zone__80B401DFFE495B3D");

            entity.ToTable("zone");

            entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Zone1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
