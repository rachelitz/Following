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

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Catering> Caterings { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

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

        modelBuilder.Entity<Catering>(entity =>
        {
            entity.HasKey(e => e.CateringCode).HasName("PK_tbl_catering");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityCode).HasName("PK_tbl_city");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryCode).HasName("PK_tbl_country");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyCode).HasName("PK_tbl_currency");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
