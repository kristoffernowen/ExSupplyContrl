namespace Core
{
    public interface IOrderService
    {
        void Create(string content);
        List<Order> Get();
    }
}
