using WamjamJumboSlam.DataLayer.Models;

namespace WamjamJumboSlam.DataLayer.Repositories.Interfaces
{
    public interface IWeaponAbilitiesRepository
    {
        Task<WeaponAbility> Get(Guid id);
        Task<Guid> Post(WeaponAbility weaponAbility);
    }
}
