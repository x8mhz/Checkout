using System;

namespace Checkout.Domain.Entities
{
    public class Coupon
    {
        protected Coupon()
        {

        }

        public Coupon(string code, decimal percentage, DateTime expireDate)
        {
            Id = Guid.NewGuid();
            Code = code;
            Percentage = percentage;
            ExpireDate = expireDate;
        }

        public Guid Id { get; private set; }
        public string Code { get; private set; }
        public decimal Percentage { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public bool IsExpired(DateTime date)
        {
            return ExpireDate < DateTime.Now;
        }

        public bool IsValid(DateTime date)
        {
            return !IsExpired(DateTime.Now);
        }

    }
}
