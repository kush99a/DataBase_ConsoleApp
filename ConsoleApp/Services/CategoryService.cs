

using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

internal class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }


    public CategoryEntity CreateCategory(string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
        categoryEntity ??= _categoryRepository.Create(new CategoryEntity { CategoryName = categoryName });

        return categoryEntity;
    }

    public CategoryEntity GetCategoryByCategoryName (string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x =>x.CategoryName == categoryName);
        return categoryEntity;
    }

    public CategoryEntity GetCategoryById (int id)
    {
        var categoryEntity
    }


}
