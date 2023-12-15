using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PetCareContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=petCare;Username=postgres;Password=1905");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Pet>()
        //        .HasOne(pet => pet.user)
        //        .WithMany()
        //        .HasForeignKey(pet => pet.UserId);

        //    modelBuilder.Entity<HealthStatus>()
        //        .HasOne(healthStatus => healthStatus.Pet)
        //        .WithMany()
        //        .HasForeignKey(healthStatus => healthStatus.PetId);
        //}


        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<HealthStatus> HealthStatuses { get; set; }
    }
}
