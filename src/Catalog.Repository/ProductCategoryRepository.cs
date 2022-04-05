using Catalog.Repository.Abstractions;
using Repository.Abstractions;
using Catalog.Entities;
using Microsoft.EntityFrameworkCore;
using Catalog.Repository.Context;

namespace Catalog.Repository
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(CatalogContext context) : base(context) { }
    }
}