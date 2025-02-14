﻿using System.Collections.Generic;
using System.Linq;
using _0_FrameWork.Application;
using _0_FrameWork.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        private readonly IProductCategoryApplication _productCategoryApplication;
        public ProductCategoryViewModel Model;

        public List<ProductCategoryViewModel> ProductCategories;

        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }

        [NeedsPermission(ShopPermissions.ListProductCategories)]
        public void OnGet(ProductCategorySearchModel searchModel)
        {
            ProductCategories = !string.IsNullOrWhiteSpace(searchModel.Name)
                ? _productCategoryApplication.Search(searchModel).OrderByDescending(x => x.Id).ToList()
                : _productCategoryApplication.Search().OrderByDescending(x => x.Id).ToList();
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public IActionResult OnGetCreate()
        {
            return Partial("Create", new CreateProductCategory());
        }

        [NeedsPermission(ShopPermissions.CreateProductCategory)]
        public JsonResult OnPostCreate(CreateProductCategory command)
        {
            var operationResult = _productCategoryApplication.Create(command);

            return new JsonResult(operationResult);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryApplication.GetDetails(id);
            return Partial("Edit", productCategory);
        }

        [NeedsPermission(ShopPermissions.EditProductCategory)]
        public JsonResult OnPostEdit(EditProductCategory command)
        {
            if (!ModelState.IsValid)
                return new JsonResult(new OperationResult().Failed("لظفا مقادیر ورودی را بررسی نمایید"));
            var operationResult = _productCategoryApplication.Edit(command);
            return new JsonResult(operationResult);
        }

        [NeedsPermission(ShopPermissions.RemoveProductCategory)]
        public JsonResult OnGetRemove(long id)
        {
            var operationResult = _productCategoryApplication.Remove(id);
            return new JsonResult(operationResult);
        }

        [NeedsPermission(ShopPermissions.RestoreProductCategory)]
        public JsonResult OnGetRestore(long id)
        {
            var operationResult = _productCategoryApplication.Restore(id);
            return new JsonResult(operationResult);
        }
    }
}