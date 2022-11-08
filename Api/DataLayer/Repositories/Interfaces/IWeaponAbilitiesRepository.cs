using Api.DataLayer.Models;

namespace Api.DataLayer.Repositories.Interfaces
{
    public interface IWeaponAbilitiesRepository
    {
        Task<WeaponAbility> Get(Guid id);
        Task<Guid> Post(WeaponAbility weaponAbility);
    }
}
