using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aw_api.Domain.Models;

namespace aw_api.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
