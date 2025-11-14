using Microsoft.EntityFrameworkCore;
using Random_Forest.Data.Interfaces;
using Random_Forest.Models;

namespace Random_Forest.Data.Repositories
{
    public class HolderRepository : IHolderRepository
    {
        private readonly AppDbContext _context;

        public HolderRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(Holder holder)
        {
            await _context.Holders.AddAsync(holder);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Holder>> GetAllAsync()
        {
            return await _context.Holders.ToListAsync();
        }

        public async Task<Holder?> GetByIdAsync(int id)
        {
            return await _context.Holders.FindAsync(id);
        }
    }
}