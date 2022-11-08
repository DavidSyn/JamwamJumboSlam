using Api.DataLayer.Models;
using Api.DataLayer.Repositories.Interfaces;

namespace Api.DataLayer.Repositories
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly DatabaseContext _context;

        public WeaponRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Guid> Post(Weapon weapon)
        {
            await _context.Weapons
                .AddAsync(weapon);
            await _context.SaveChangesAsync();
            return weapon.Id;
        }

        public async Task<Weapon> Update(Weapon weapon)
        {
            _context.Weapons
                .Update(weapon);
            await _context.SaveChangesAsync();
            return weapon;
        }
    }
}
