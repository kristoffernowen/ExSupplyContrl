using Dtos;

namespace Services.Contracts;

public interface IOrderService
{
    void Create(string content);
    List<OrderOutputDto> Get();
}