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

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<ExpenseInJourney> ExpenseInJourneys { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<GroupType> GroupTypes { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelService> HotelServices { get; set; }

    public virtual DbSet<HotelServiceParticular> HotelServiceParticulars { get; set; }

    public virtual DbSet<Journey> Journeys { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<MealsInJourney> MealsInJourneys { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }

    public virtual DbSet<PassengerInJourney> PassengerInJourneys { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductInMenu> ProductInMenus { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<RationType> RationTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<SchedulingMeal> SchedulingMeals { get; set; }

    public virtual DbSet<SchedulingService> SchedulingServices { get; set; }

    public virtual DbSet<ServiceCateringTariff> ServiceCateringTariffs { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamInJourney> TeamInJourneys { get; set; }

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

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.ExpenseCode).HasName("PK_tbl_expense");
        });

        modelBuilder.Entity<ExpenseInJourney>(entity =>
        {
            entity.HasKey(e => e.ExpenseInJourneyCode).HasName("PK_tbl_expenseInJourney");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.FlightCode).HasName("PK_tbl_flight");

            entity.Property(e => e.FlightCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.HasKey(e => e.GoalCode).HasName("PK_tbl_goal");
        });

        modelBuilder.Entity<GroupType>(entity =>
        {
            entity.HasKey(e => e.TypeGroupCode).HasName("PK_tbl_groupType");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelCode).HasName("PK_tbl_hotel");
        });

        modelBuilder.Entity<HotelService>(entity =>
        {
            entity.HasKey(e => e.HotelServiceCode).HasName("PK_tbl_hotelService");
        });

        modelBuilder.Entity<HotelServiceParticular>(entity =>
        {
            entity.HasKey(e => e.HotelServiceParticularCode).HasName("PK_tbl_hotelServiceParticular");
        });

        modelBuilder.Entity<Journey>(entity =>
        {
            entity.HasKey(e => e.JourneyCode).HasName("PK_tbl_journey");
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.MealTypeCode).HasName("PK_tbl_meal");
        });

        modelBuilder.Entity<MealsInJourney>(entity =>
        {
            entity.HasKey(e => e.MealInJourneyCode).HasName("PK_tbl_mealsInJourney");
        });

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.PassengerId).HasName("PK_tbl_passenger");
        });

        modelBuilder.Entity<PassengerInJourney>(entity =>
        {
            entity.HasKey(e => e.PassengerInJournetCode).HasName("PK_tbl_passengerInJourney");

            entity.Property(e => e.PassengerInJournetCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode).HasName("PK_tbl_product");
        });

        modelBuilder.Entity<ProductInMenu>(entity =>
        {
            entity.HasKey(e => e.ProductInMenu1).HasName("PK_tbl_productInMenu");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.RatingCode).HasName("PK_tbl_rating");
        });

        modelBuilder.Entity<RationType>(entity =>
        {
            entity.HasKey(e => e.RationTypeCode).HasName("PK_tbl_rationType");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleCode).HasName("PK_tbl_role");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteCode).HasName("PK_tbl_route");
        });

        modelBuilder.Entity<SchedulingMeal>(entity =>
        {
            entity.HasKey(e => e.SchedulingMealCode).HasName("PK_tbl_schedulingMeals");
        });

        modelBuilder.Entity<SchedulingService>(entity =>
        {
            entity.HasKey(e => e.SchedulingServiceCode).HasName("PK_tbl_schedulingService");
        });

        modelBuilder.Entity<ServiceCateringTariff>(entity =>
        {
            entity.HasKey(e => e.ServiceCateringTariffCode).HasName("PK_tbl_serviceCateringTariff");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteCode).HasName("PK_tbl_site");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.StatusCode).HasName("PK_tbl_status");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_tbl_team");
        });

        modelBuilder.Entity<TeamInJourney>(entity =>
        {
            entity.HasKey(e => e.TeamInJourneyCode).HasName("PK_tbl_teamInJourney");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
