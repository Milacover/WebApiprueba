using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Services
{
    public class ProductService : IProductService
    {
        //private readonly IProductService _productService;
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;

        }

        public void DeleteProductById(int id)
        {
            _productLogic.DeleteProductById( id);
        }

        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }

        public int PatchProduct(ProductItem productItem)
        {
            _productLogic.PatchProductItem(productItem);
            return productItem.Id;
        }

        public List<ProductItem> GetProduct()
        {
         return _productLogic.GetProductItem();
            // var resultlist =  _productLogic.GetProductItem(); return resultlist;
        }
    }
}
