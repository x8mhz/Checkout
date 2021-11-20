using Checkout.Domain.Entities;

namespace Checkout.Domain.Interfaces.Repositories
{ 

    public interface IOrderRepository
    {
        void Save(Order order);

    }
}