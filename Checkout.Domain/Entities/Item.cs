using System;

namespace Checkout.Domain.Entities
{
    public class Item
    {
        public Item(int itemId, int volume, string category, string description, decimal price, decimal width, decimal height, decimal lenght, decimal weight)
        {
            Id = Guid.NewGuid();
            ItemId = itemId;
            Volume = volume;
            Category = category;
            Description = description;
            Price = price;
            Width = width;
            Height = height;
            Lenght = lenght;
            Weight = weight;
        }

        public Guid Id { get; private set; }
        public int ItemId { get; private set; }

        public int Volume { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public decimal Width { get; private set; }
        public decimal Height { get; private set; }
        public decimal Lenght { get; private set; }
        public decimal Weight { get; private set; }

        public decimal GetVolume()
        {
            return Width / 100 * Height / 100 * Lenght / 100;
        }

        public decimal GetDensity()
        {
            return Weight / GetVolume();
        }

        public decimal GetFreight()
        {
            var freight = 1000 * GetVolume() * (GetDensity() / 100);
            return (freight < 10) ? 10 : freight;
        }
    }
}
