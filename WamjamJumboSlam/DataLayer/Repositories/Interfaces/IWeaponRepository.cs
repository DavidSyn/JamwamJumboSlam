using WamjamJumboSlam.DataLayer.Models;

namespace WamjamJumboSlam.DataLayer.Repositories.Interfaces
{
    public interface IWeaponRepository
    {
        Task<Guid> Post(Weapon weapon);
        Task<Weapon> Update(Weapon weapon);
    }
}
