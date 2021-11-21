using Checkout.Domain.Entities;
using Checkout.Domain.Interfaces.Repositories;
using Checkout.Infra.Data.Context;

namespace Checkout.Infra.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CheckoutContext _context;

        public OrderRepository(CheckoutContext context)
        {
            _context = context;
        }
        void IOrderRepository.Save(Order order)
        {
            _context.Set<Order>().Add(order);
            _context.SaveChanges();
        }
    }
}
