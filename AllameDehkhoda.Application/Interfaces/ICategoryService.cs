using AllameDehkhoda.Application.DTO;

namespace AllameDehkhoda.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategoryAsync(); 
    }
}
