using Api.DataLayer.Models;

namespace Api.DataLayer.Repositories.Interfaces
{
    public interface IWeaponRepository
    {
        Task<Guid> Post(Weapon weapon);
        Task<Weapon> Update(Weapon weapon);
    }
}
