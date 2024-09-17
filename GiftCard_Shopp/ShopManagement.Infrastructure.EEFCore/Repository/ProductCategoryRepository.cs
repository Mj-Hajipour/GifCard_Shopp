using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System.Linq.Expressions;

namespace ShopManagement.Infrastructure.EEFCore.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ShopContext _Context;

        public ProductCategoryRepository(ShopContext context)
        {
            _Context = context;
        }

        public void Create(ProductCategory entity)
        {
            _Context.ProductCategories.Add(entity);
        }

        public bool Exist(Expression<Func<ProductCategory, bool>> expression)
        {
            return _Context.ProductCategories.Any(expression);
        }

        public ProductCategory Get(long id)
        {
            return _Context.ProductCategories.Find(id);
        }

        public List<ProductCategory> GetAll()
        {
            return _Context.ProductCategories.ToList();
        }

        public EditProductCategory GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
