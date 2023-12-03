using BlogManagement.Application;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiseHost.Areas.Administration.Pages.Blog.ArticleCategories
{
    public class IndexModel : PageModel
    {
        public ArticleCategorySearchModel SearchModel;
        public List<ArticleCategoryViewModel> ArticleCategories;

        private readonly IArticleCategoryApplication _articleCategoryAppilcation;

        public IndexModel(IArticleCategoryApplication articleCategoryAppilcation)
        {
            _articleCategoryAppilcation = articleCategoryAppilcation;
        }

        public void OnGet(ArticleCategorySearchModel searchModel)
        {
            ArticleCategories = _articleCategoryAppilcation.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateArticleCategory());
        }
        public JsonResult OnPostCreate(CreateArticleCategory command)
        {
            var result = _articleCategoryAppilcation.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _articleCategoryAppilcation.GetDetails(id);
            return Partial("Edit", productCategory);
        }
        public JsonResult OnPostEdit(EditArticleCategory command)
        {
            var result = _articleCategoryAppilcation.Edit(command);
            return new JsonResult(result);
        }
    }
}
