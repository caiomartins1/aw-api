using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aw_api.Domain.Models;
using aw_api.Domain.Repositories;
using aw_api.Persistence.Contexts;
using System.Collections.Generic;

namespace aw_api.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
