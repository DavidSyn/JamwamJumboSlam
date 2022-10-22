using WamjamJumboSlam.DataLayer.Models;

namespace WamjamJumboSlam.DataLayer.Repositories.Interfaces
{
    public interface IWeaponAbilitiesRepository
    {
        Task<Guid> Post(WeaponAbility weaponAbility);
    }
}
