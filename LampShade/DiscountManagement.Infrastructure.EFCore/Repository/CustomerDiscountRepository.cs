﻿using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contract;
using DiscountManagement.Domain.CustomerDiscountAgg;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class CustomerDiscountRepository : RepositoryBase<long , CustomerDiscount> , ICustomerDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;

        public CustomerDiscountRepository(DiscountContext context, ShopContext shopContext) :base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditCustomerDiscount GetDetails(long id)
        {
           return _context.CustomerDiscounts.Select(x => new EditCustomerDiscount
           {
               Id = x.Id,
               ProductId = x.ProductId,
               DiscountRate = x.DiscountRate,
               StartDate = x.StartDate.ToString(),
               EndDate = x.EndDate.ToString(),
               Reason = x.Reason,
           }).FirstOrDefault(x => x.Id == id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new { x.Id, x.Name }).ToList();
            var query = _context.CustomerDiscounts.Select(x => new CustomerDiscountViewModel
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                EndDate = x.EndDate.ToString(),
                EndDateGr = x.EndDate,
                StartDate = x.StartDate.ToString(),
                StartDateGr = x.StartDate,
                ProductId = x.ProductId,
                Reason = x.Reason,

            });
            if(searchModel.ProductId > 0)
                query = query.Where(x => x.ProductId == searchModel.ProductId);

            if (!string.IsNullOrWhiteSpace(searchModel.StartDate))
            {
                var startDate = DateTime.Now;
                query = query.Where(x => x.StartDateGr > startDate);

            }
            if (!string.IsNullOrWhiteSpace(searchModel.EndDate))
            {
                var endDate = DateTime.Now;
                query = query.Where(x => x.EndDateGr < endDate);
            }

            var discounts = query.OrderByDescending(x => x.Id).ToList();

            discounts.ForEach(discount =>
            discount.Product = products.FirstOrDefault(x => x.Id == discount.ProductId)?.Name);

            return discounts;
        }
    }
}
