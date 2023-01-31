using Entities.Entities;

namespace APIService.IServices
{
    public interface IOrderService
    {

        void DeleteOrderById(int id);
        List<OrderItem> GetOrder();
        int InsertOrder(OrderItem orderItem);
        int PatchOrder(OrderItem orderItem);
    }
}
