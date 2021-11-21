using Checkout.Domain.Entities;
using Checkout.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Checkout.Infra.Data.Context
{
    public class CheckoutContext : DbContext
    {
        public CheckoutContext(DbContextOptions<CheckoutContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = DbCheckout; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new CouponMap());
            model.ApplyConfiguration(new ItemMap());
            model.ApplyConfiguration(new OrderMap());
            model.ApplyConfiguration(new OrderItemMap());


        }
    }
}
