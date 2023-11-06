﻿using _01_LampshadeQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiseHost.ViewComponents
{
    public class ProductCategoryViewComponent : ViewComponent
    {
         private readonly IProductCategoryQuery _productCategoryQuery;

        public ProductCategoryViewComponent(IProductCategoryQuery productCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
        }
        public IViewComponentResult Invoke()
        {
            var productCategories = _productCategoryQuery.GetProductCategories();
            return View(productCategories);
        }
    }
}
