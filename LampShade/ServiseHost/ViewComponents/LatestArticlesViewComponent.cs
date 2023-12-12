using _01_LampshadeQuery.Contract.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiseHost.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
         private readonly IArticleQuery _articleQuery;

        public LatestArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }
        public IViewComponentResult Invoke()
        {
            var products = _articleQuery.LatestArticles();
            return View(products);
        }
    }
}
