using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aw_api.Domain.Models;
using aw_api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace aw_api.Controllers
{

    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}
