using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Collections.Generic;

namespace Sm.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository) 
        {
          _productCategoryRepository = productCategoryRepository;
        }
        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if(_productCategoryRepository.Exist(command.Name))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.لطفا مجدد تلاش بفرمایید");

            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture,
                command.PictureAlt,command.PictureTitle,command.Keywords,command.MetaDescription,command.Slug)
            {
              
            };
        }

        public OperationResult Edit(EditProductCategory command)
        {
           
        }

        public ProductCategory GetDetails(long id)
        {
           
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
           
        }
    }
}
