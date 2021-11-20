using Checkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkout.Infra.Data.Mapping
{
    public class CouponMap : IEntityTypeConfiguration<Coupon>
    {
        void IEntityTypeConfiguration<Coupon>.Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Percentage)
                .IsRequired();

            builder.Property(x => x.ExpireDate)
                .IsRequired();
        }
    }
}
