using Api.DataLayer.Models;

namespace Api.DataLayer.Repositories.Interfaces
{
    public interface IWeaponAbilitiesRepository
    {
        Task<List<WeaponAbility>> Get();
        Task<WeaponAbility> Get(Guid id);
        Task<Guid> Post(WeaponAbility weaponAbility);
    }
}
