using Checkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkout.Infra.Data.Mapping
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        void IEntityTypeConfiguration<OrderItem>.Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ItemId)
                .IsRequired();

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();
        }
    }
}
