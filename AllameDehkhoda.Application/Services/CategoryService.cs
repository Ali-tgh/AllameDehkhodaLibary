using AllameDehkhoda.Application.DTO;
using AllameDehkhoda.Application.Interfaces;
using AllameDehkhoda.Domain.Intrefaces;

namespace AllameDehkhoda.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDTO>> GetAllCategoryAsync()
        {
            var category = await _categoryRepository.GetAllAsync();
            return category.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }
    }
}
