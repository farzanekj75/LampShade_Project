﻿using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShopManagement.Appilication
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        public OperationResult Create(CreateProduct command)
        {
           var operation = new OperationResult();
            if(_productRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicateRecord);

            var slug = command.Slug.Slugify();
            var product = new Product(command.Name, command.Code, command.UnitPrice,
                command.ShortDescription, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription);
            _productRepository.Create(product);
            _productRepository.SaveChanges();
            return operation.Succedded();   
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);
            if(product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id !=command.Id))
                return operation.Failed(ApplicationMessages.DuplicateRecord);

            var slug = command.Slug.Slugify();
            product.Edit(command.Name, command.Code, command.UnitPrice,
                command.ShortDescription, command.Description, command.Picture,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription);
            
            _productRepository.SaveChanges();
            return operation.Succedded();


        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);   
        }

        public OperationResult IsStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

          
            product.InStock();

            _productRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult NotInStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);


            product.NotInStock();

            _productRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }
    }
}
