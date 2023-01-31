using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _orderService;
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;

        }

        public void DeleteOrderById(int id)
        {
            _orderLogic.DeleteOrderById(id);
        }

        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }

        public int PatchOrder(OrderItem orderItem)
        {
            _orderLogic.PatchOrderItem(orderItem);
            return orderItem.Id;
        }

        public List<OrderItem> GetOrder()
        {
            return _orderLogic.GetOrderItem();
            // var resultlist =  _orderLogic.GetOrderItem(); return resultlist;
        }
    }
}
