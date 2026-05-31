using System;
using System.Collections.Generic;
using FollowingDal.Model;
using Microsoft.EntityFrameworkCore;

namespace FollowingDal.Context;

public partial class FollowingDBContext : DbContext
{
    public FollowingDBContext(DbContextOptions<FollowingDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<BusCompany> BusCompanies { get; set; }

    public virtual DbSet<BusesCost> BusesCosts { get; set; }

    public virtual DbSet<BusinessCustomer> BusinessCustomers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.CompanyCode).HasName("PK_tbl_airline");
        });

        modelBuilder.Entity<BusCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyCode).HasName("PK_tbl_busCompany");
        });

        modelBuilder.Entity<BusesCost>(entity =>
        {
            entity.HasKey(e => e.BusesCostCode).HasName("PK_tbl_busesCost");
        });

        modelBuilder.Entity<BusinessCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerCode).HasName("PK_tbl_businessCustomer");

            entity.Property(e => e.CustomerCode).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
