using _01_LampshadeQuery.Contract.Article;
using _01_LampshadeQuery.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiseHost.ViewComponents;
using System.Collections.Generic;

namespace ServiseHost.Pages
{
    public class ArticleCategoryModel : PageModel
    {
        public ArticleCategoryQueryModel ArticleCategory;
        public List<ArticleCategoryQueryModel> ArticleCategories;
        public List<ArticleQueryModel> LatestArticles;

        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public ArticleCategoryModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet(string id)
        {
            LatestArticles = _articleQuery.LatestArticles();
            ArticleCategory = _articleCategoryQuery.GetArticleCategory(id);
            ArticleCategories = _articleCategoryQuery.getArticlesCategories();
        }
    }
}
