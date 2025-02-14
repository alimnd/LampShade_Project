﻿using System.Collections.Generic;
using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IFileUploader _fileUploader;
        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository, IFileUploader fileUploader)
        {
            _productCategoryRepository = productCategoryRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_productCategoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var pictureFileName = _fileUploader.UploadFile(command.Picture, command.Slug);

            var productCategory = new ProductCategory(command.Name, command.Description, pictureFileName,
                command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChange();
            return operation.Succeed();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);

            if (productCategory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_productCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var pictureFileName = _fileUploader.UploadFile(command.Picture, command.Slug);
            var slug = command.Slug.Slugify();
            productCategory.Edit(command.Name, command.Description, pictureFileName,
                command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.SaveChange();
            return operation.Succeed();
        }

        public OperationResult Remove(long id)
        {
            var operationResult = new OperationResult();
            var productCategory = _productCategoryRepository.Get(id);
            if (productCategory == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);

            productCategory.Remove();
            _productCategoryRepository.SaveChange();
            return operationResult.Succeed();

        }

        public OperationResult Restore(long id)
        {
            var operationResult = new OperationResult();
            var productCategory = _productCategoryRepository.Get(id);
            if (productCategory == null)
                return operationResult.Failed(ApplicationMessages.RecordNotFound);
            productCategory.Restore();
            _productCategoryRepository.SaveChange();
            return operationResult.Succeed();
        }

        public EditProductCategory GetDetails(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }

        public List<ProductCategoryViewModel> Search()
        {
            return _productCategoryRepository.Search();
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            return _productCategoryRepository.GetProductCategories();
        }
    }
}