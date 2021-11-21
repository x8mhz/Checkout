using Checkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkout.Infra.Data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        void IEntityTypeConfiguration<Order>.Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired();

            builder.Property(x => x.Shipping)
                .IsRequired();

            builder.Property(x => x.IssueDate)
                .IsRequired();

            builder.Property(x => x.Document)
                .IsRequired();

            builder.Property(x => x.Coupon)
                .IsRequired();

            builder.HasMany(x => x.OrderItems)
                .WithOne(x => x.Order);
        }
    }
}
