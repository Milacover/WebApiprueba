using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        void DeleteOrderById(int Id, OrderItem selectedOrder);
        List<OrderItem> GetOrderItem();
        void InsertOrderItem(OrderItem orderItem);
        void PatchOrderItem(OrderItem orderItem);
    }
}
