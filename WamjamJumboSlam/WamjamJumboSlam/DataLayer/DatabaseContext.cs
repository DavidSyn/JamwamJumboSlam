using Microsoft.EntityFrameworkCore;
using WamjamJumboSlam.DataLayer.Models;

namespace WamjamJumboSlam.DataLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponProfile> WeaponsProfiles { get; set; }
        public DbSet<WeaponAbility> WeaponsAbilities { get; set; }
    }
}
