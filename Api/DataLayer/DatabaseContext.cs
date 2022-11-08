using Microsoft.EntityFrameworkCore;
using Api.DataLayer.Models;

namespace Api.DataLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponProfile> WeaponsProfiles { get; set; }
        public DbSet<WeaponAbility> WeaponsAbilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weapon>().ToTable("Weapon");
            modelBuilder.Entity<WeaponProfile>().ToTable("WeaponProfile");
            modelBuilder.Entity<WeaponAbility>().ToTable("WeaponAbility");
        }
    }
}
