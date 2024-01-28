using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Configuration.Permission
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product" , new List<PermissionDto>
                    {
                        new PermissionDto(10 , "ListProducts"),
                        new PermissionDto(11 , "SearchProducts"),
                        new PermissionDto(12 , "CreateProduct"),
                        new PermissionDto(13 , "EditProduct"),
                    }
                },
                {
                    "ProductCategory" , new List<PermissionDto>
                    {
                        new PermissionDto(20,"SearchProductCategories"),
                        new PermissionDto(20,"ListProductCategories"),
                        new PermissionDto(20,"CreateProductCategory"),
                        new PermissionDto(20,"EditProductCategory"),
                    }
                }
            };
        }
    }
}
