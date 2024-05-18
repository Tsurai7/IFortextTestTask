using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    /// <summary>
    /// IOrderService.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    public interface IOrderService
    {
        public Task<Order> GetOrder();

        public Task<List<Order>> GetOrders();
    }
}
