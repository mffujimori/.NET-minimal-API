using Random_Forest.Models;

namespace Random_Forest.Data.Interfaces
{
    public interface IHolderRepository
    {
        Task AddAsync(Holder holder);
        Task<Holder?> GetByIdAsync(int id);
        Task<IEnumerable<Holder>> GetAllAsync();
    }
    
}