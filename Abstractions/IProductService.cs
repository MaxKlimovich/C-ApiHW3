using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Abstractions
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProducts();
        int AddProduct(ProductDto product);
    }
}
