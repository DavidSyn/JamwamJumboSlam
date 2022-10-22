using WamjamJumboSlam.DataLayer.Models;
using WamjamJumboSlam.DataLayer.Repositories.Interfaces;

namespace WamjamJumboSlam.DataLayer.Repositories
{
    public class WeaponAbilitiesRepository : IWeaponAbilitiesRepository
    {
        private readonly DatabaseContext _context;

        public WeaponAbilitiesRepository(
            DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Guid> Post(WeaponAbility weaponAbility)
        {
            await _context.WeaponsAbilities.AddAsync(weaponAbility);
            await _context.SaveChangesAsync();
            return weaponAbility.Id;
        }
    }
}
