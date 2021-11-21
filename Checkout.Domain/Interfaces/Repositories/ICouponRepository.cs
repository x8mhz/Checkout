using Checkout.Domain.Entities;

namespace Checkout.Domain.Interfaces.Repositories
{

    public interface ICouponRepository
    {
        Coupon FindByCode(string code);

    }
}