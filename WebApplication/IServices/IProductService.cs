using Entities.Entities;

namespace APIService.IServices
{
    public interface IProductService
    {
        
        void DeleteProductById(int id);
        List<ProductItem> GetProduct();
        int InsertProduct(ProductItem productItem);
        int PatchProduct(ProductItem productItem);
    }
}
