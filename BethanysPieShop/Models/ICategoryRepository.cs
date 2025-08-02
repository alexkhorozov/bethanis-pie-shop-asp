namespace BethanysPieShop.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
    Category? GetCategoryById(int categoryId);
    //void AddCategory(Category category);
    //void UpdateCategory(Category category);
    //void DeleteCategory(int categoryId);
}
