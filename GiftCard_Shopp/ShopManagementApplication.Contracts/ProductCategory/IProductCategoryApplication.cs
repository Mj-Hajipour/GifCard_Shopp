﻿using _0_FrameWork.Application;
using System.Collections.Generic;
namespace ShopManagement.Application.Contracts.ProductCategory
{
    public  interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}  
