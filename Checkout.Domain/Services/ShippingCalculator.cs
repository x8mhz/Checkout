using Checkout.Domain.Entities;

namespace Checkout.Domain.Services
{
    public  class ShippingCalculator
    {
        public ShippingCalculator(Item item)
        {
            Item = item;
        }

        public Item Item{ get; private set; }

        public decimal Shipping()
        {
            var shipping = 1000 * Item.GetVolume() * (Item.GetDensity() / 100);
            return (shipping < 100) ? 10 : shipping;
        }
    }
}
