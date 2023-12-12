using _0_Framework.Application;
using _01_LampshadeQuery.Contract.Article;
using _01_LampshadeQuery.Contract.ArticleCategory;
using BlogManagement.Application.Contracts.ArticleCategory;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampshadeQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _contetx;

        public ArticleCategoryQuery(BlogContext contetx)
        {
            _contetx = contetx;
        }

        public ArticleCategoryQueryModel GetArticleCategory(string slug)
        {
           var articleCategory = _contetx.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Slug = x.Slug,
                    Name = x.Name,
                    Description = x.Description,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    CanonicalAddress = x.CanonicalAddress,
                    ArticleCount = x.Articles.Count,
                    Articles = MapArticles(x.Articles)
                }).FirstOrDefault(x => x.Slug == slug);
            if(!string.IsNullOrWhiteSpace(articleCategory.Keywords))
                articleCategory.KeywordsList = articleCategory.Keywords.Split(",").ToList();


            return articleCategory;
        }

        private static List<ArticleQueryModel> MapArticles(List<Article> articles)
        {
           return articles.Select(x => new ArticleQueryModel
           {
               Slug = x.Slug,
               ShortDescription = x.ShortDescription,
               Title = x.Title,
               Picture = x.Picture,
               PictureAlt= x.PictureAlt,
               PictureTitle = x.PictureTitle,
               PublishDate = x.PublishDate.ToFarsi()
           }).ToList();
        }

        public List<ArticleCategoryQueryModel> getArticlesCategories()
        {
           return _contetx.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    ArticleCount = x.Articles.Count
                }).ToList();
        }
    }
}
