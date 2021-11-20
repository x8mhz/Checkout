using Checkout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Checkout.Infra.Data.Mapping
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        void IEntityTypeConfiguration<Item>.Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ItemId)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Volume)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Width)
                .IsRequired();

            builder.Property(x => x.Weight)
                .IsRequired();

            builder.Property(x => x.Height)
                .IsRequired();

            builder.Property(x => x.Lenght)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();
        }
    }
}
