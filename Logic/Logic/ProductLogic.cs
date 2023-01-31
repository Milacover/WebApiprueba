using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public void DeleteProductById( int Id)
        {
            var chooseProduct = _serviceContext.Set<ProductItem>().Where(p => p.Id == Id).First();
            chooseProduct.IsActive = false;
            _serviceContext.SaveChanges();

            // Filtra
            //var selectedProduct = _serviceContext.Set<ProductItem>().ToList().Where(p => p.IsActive).ToList();

            // Trae el primero
            //var firstProduct = _serviceContext.Set<ProductItem>().First();
            //firstProduct.InsertDate = DateTime.Now;

            // Lo modifica
            //_serviceContext.SaveChanges();

        }


        public void InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
        }

        public void PatchProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);
          //var firstProduct = _serviceContext.Set<ProductItem>().First();
            
            _serviceContext.SaveChanges();
        }

        public List<ProductItem> GetProductItem()
        {
            return _serviceContext.Set<ProductItem>().ToList();
         
        }
    }
}
