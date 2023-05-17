using Core;
using Services.Contracts;

namespace Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public void Create(string content)
    {
        var order = new Order
        {
            Content = content
        };
        _orderRepository.Create(order);
        _orderRepository.Save();
    }

    public List<Order> Get()
    {
        return _orderRepository.Get();
    }
}