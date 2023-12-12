﻿using _01_LampshadeQuery;
using _01_LampshadeQuery.Contract.ArticleCategory;
using _01_LampshadeQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiseHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery _productCategoryQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;


        public MenuViewComponent(IProductCategoryQuery productCategoryQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var result = new MenuModel 
            {
                ArticleCategories = _articleCategoryQuery.getArticlesCategories(),
                ProductCategories = _productCategoryQuery.GetProductCategories(),
            };
            return View(result);
        }
    }
}
