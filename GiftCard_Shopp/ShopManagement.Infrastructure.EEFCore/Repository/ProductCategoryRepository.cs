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
            return _Context.ProductCategories.Select(x => new EditProductCategory()
            {
                Id = x.Id,
                Description = x.Description,
                Name=x.Name,
                Keywords=x.Keywords,
                MetaDescription=x.MetaDescription,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle,
                Slug=x.Slug
            }).FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _Context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Name = x.Name,
                CreationDate = x.CreationDate.ToString()
            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
