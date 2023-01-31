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
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        private int id;

        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public void DeleteOrderById(int Id)
        {
            var chooseOrder = _serviceContext.Set<OrderItem>().Where(p => p.Id == Id).First();
            chooseOrder.IsActive = false; 
            _serviceContext.SaveChanges();
            //var userToDelete = _serviceContext.Set<OrderItem>()
            //.Where(u => u.Id == id).First();

            // userToDelete.IsActive = false;

            //_serviceContext.SaveChanges();

        }

        public void InsertOrderItem(OrderItem orderItem )
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
        }

        public void PatchOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            //var firstProduct = _serviceContext.Set<ProductItem>().First();

            _serviceContext.SaveChanges();
        }

        public List<OrderItem> GetOrderItem()
        {
            return _serviceContext.Set<OrderItem>().ToList();

        }
    }
}
