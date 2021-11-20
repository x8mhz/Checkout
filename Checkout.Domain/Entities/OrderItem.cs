using System;

namespace Checkout.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(int itemId, decimal price, int quantity)
        {
            Id = Guid.NewGuid();
            ItemId = itemId;
            Price = price;
            Quantity = quantity;
        }

        public Guid Id { get; private set; }
        public int ItemId { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }
    }
}
