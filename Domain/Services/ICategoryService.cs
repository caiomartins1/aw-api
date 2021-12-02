using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aw_api.Domain.Models;

namespace aw_api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
