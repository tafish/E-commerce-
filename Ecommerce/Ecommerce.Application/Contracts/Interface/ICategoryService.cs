﻿using Ecommerce.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task CreateCategory(Category category);
        Task UpdateCategory(Category category);
        Task DeleteCategory(int id);
    }
}
