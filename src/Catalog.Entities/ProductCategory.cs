using Entities.Abstractions;

namespace Catalog.Entities
{
    public class ProductCategory : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public Guid MainCategoryId {get;set;}
    }
}