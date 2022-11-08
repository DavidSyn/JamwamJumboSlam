using Api.DataLayer.Models;
using Api.DataLayer.Repositories.Interfaces;

namespace Api.DataLayer.Repositories
{
    public class WeaponAbilitiesRepository : IWeaponAbilitiesRepository
    {
        private readonly DatabaseContext _context;

        public WeaponAbilitiesRepository(
            DatabaseContext context)
        {
            _context = context;
        }

        public async Task<WeaponAbility> Get(Guid id)
        {
            var result = await _context.WeaponsAbilities.FindAsync(id);

            if (result == null)
            {
                return new WeaponAbility();
            }
            return result;
        }

        public async Task<Guid> Post(WeaponAbility weaponAbility)
        {
            await _context.WeaponsAbilities.AddAsync(weaponAbility);
            await _context.SaveChangesAsync();
            return weaponAbility.Id;
        }
    }
}
