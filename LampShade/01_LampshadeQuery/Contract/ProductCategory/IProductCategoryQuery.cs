using System.Collections.Generic;

namespace _01_LampshadeQuery.Contract.ProductCategory
{
    public interface IProductCategoryQuery
    {
        ProductCategoryQueryModel GetQueryModelWithProductsBy(string slug);
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
    }
}
