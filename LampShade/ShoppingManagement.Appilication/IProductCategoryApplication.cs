using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Appilication
{
    public class ProductCategoryApplication : IProductCategoryAppilcation
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public void Create(CreateProductCategory command)
        {
            throw new NotImplementedException();
        }

        public void Edit(EditProductCategory command)
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
