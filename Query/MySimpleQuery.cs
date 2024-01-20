using WebAppGrapQL.Abstractions;
using WebAppGrapQL.Models;
using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Query
{
    public class MySimpleQuery
    {
        public IEnumerable<ProductDto> GetProducts([Service] IProductService service) => service.GetProducts();
        public IEnumerable<StorageDto> GetStorages([Service] IStorageService service) => service.GetStorages();
        public IEnumerable<CategoryDto> GetCategories([Service] ICategoryService service) => service.GetCategories();
    }
}
