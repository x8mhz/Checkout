using Checkout.Domain.Interfaces.Repositories;

namespace Checkout.Domain.Interfaces.Factories
{
    public interface ICheckoutFactory
    {
        abstract IItemRepository CreateItemRepository();
        abstract ICouponRepository CreateCouponRepository();
        abstract IOrderRepository CreateOrderRepository();
    }
}
