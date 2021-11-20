using Checkout.Domain.Entities;
using Checkout.Domain.Interfaces.Repositories;
using Checkout.Infra.Data.Context;


namespace Checkout.Infra.Data.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        private readonly CheckoutContext _context;
        public CouponRepository(CheckoutContext context)
        {
            _context = context;
        }

        Coupon ICouponRepository.FindByCode(string code)
        {
            return _context.Set<Coupon>().Find(code);
        }
    }
}
