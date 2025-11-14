using Random_Forest.Models;

namespace Random_Forest.Services.Interfaces
{
    public interface IHolderService
    {
        Task CreateHolderAsync(Holder newHolder);
        Task<Holder?> GetHolderByIdAsync(int id);
        Task<IEnumerable<Holder>> GetAllHoldersAsync();
    }
}