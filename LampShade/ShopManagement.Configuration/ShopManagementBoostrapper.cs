﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Appilication;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Configuration
{
    public class ShopManagementBoostrapper
    {
        public static void Configure(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IProductCategoryAppilcation, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
