using Checkout.Domain.Interfaces.Factories;
using Checkout.Domain.Interfaces.Repositories;
using Checkout.Infra.Data.Context;
using Checkout.Infra.Data.Repositories;

namespace Checkout.Infra.Data.Factories
{
    public class CheckoutRepositoryFactory : ICheckoutFactory
    {
        private readonly CheckoutContext _context;

        public CheckoutRepositoryFactory(CheckoutContext context)
        {
            _context = context;
        }

        ICouponRepository ICheckoutFactory.CreateCouponRepository()
        {
            return new CouponRepository(_context);
        }

        IItemRepository ICheckoutFactory.CreateItemRepository()
        {
            return new ItemRepository(_context);
        }

        IOrderRepository ICheckoutFactory.CreateOrderRepository()
        {
            return new OrderRepository(_context);
        }
    }
}
