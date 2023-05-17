using AutoMapper;
using Core;
using Dtos;
using Services.Contracts;

namespace Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;


    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
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

    public List<OrderOutputDto> Get()
    {
        var list = _orderRepository.Get().ToList();

        return list.Select(o => _mapper.Map<OrderOutputDto>(o)).ToList();
    }
}
