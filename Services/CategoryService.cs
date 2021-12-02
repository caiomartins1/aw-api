using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aw_api.Domain.Models;
using aw_api.Domain.Repositories;
using aw_api.Domain.Services;

namespace aw_api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
