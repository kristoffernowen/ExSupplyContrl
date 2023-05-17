using Core;

namespace Services.Contracts;

public interface IOrderService
{
    void Create(string content);
    List<Order> Get();
}