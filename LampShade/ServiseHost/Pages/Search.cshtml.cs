using _01_LampshadeQuery.Contract.Product;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiseHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public List<ProductQueryModel> Products;
        private readonly IProductQuery _productQuery;

        public SearchModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        public void OnGet(string value)
        {
            Value = value;
            Products = _productQuery.Search(value);
        }
    }
}
