using Random_Forest.Data.Interfaces;
using Random_Forest.Models;
using Random_Forest.Services.Interfaces;

namespace Random_Forest.Services
{
    public class HolderService : IHolderService
    {
        private readonly IHolderRepository _holderRepository;

        public HolderService(IHolderRepository holderRepository)
        {
            _holderRepository = holderRepository;
        }

        public async Task CreateHolderAsync(Holder newHolder)
        {
            // void
            // void
            // void
            // void
            // void
            // void
            // void
            // void
            // void
            // void
            // void REGRAS COLOCAMOS DPS
            // ---------------------------------------------
            await _holderRepository.AddAsync(newHolder);
        }

        public async Task<IEnumerable<Holder>> GetAllHoldersAsync()
        {
            return await _holderRepository.GetAllAsync();
        }

        public async Task<Holder?> GetHolderByIdAsync(int id)
        {
            return await _holderRepository.GetByIdAsync(id);
        }
    }
}