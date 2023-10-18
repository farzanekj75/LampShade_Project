using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;

namespace ServiseHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategories;
        private readonly IProductPictureAppilcation _productCategoryAppilcation;

        public IndexModel(IProductPictureAppilcation productCategoryAppilcation)
        {
            _productCategoryAppilcation = productCategoryAppilcation;
        }

        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategories = _productCategoryAppilcation.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var result = _productCategoryAppilcation.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryAppilcation.GetDetails(id);
            return Partial("Edit", productCategory);
        }
        public JsonResult OnPostEdit(EditProductCategory command)
        {
            var result = _productCategoryAppilcation.Edit(command);
            return new JsonResult(result);
        }
    }
}
