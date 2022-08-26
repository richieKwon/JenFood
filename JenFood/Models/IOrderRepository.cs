namespace JenFood.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}