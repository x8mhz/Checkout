using Checkout.Domain.Entities;
using Checkout.Domain.Interfaces.Repositories;
using Checkout.Infra.Data.Context;

namespace Checkout.Infra.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly CheckoutContext _context;
        public ItemRepository(CheckoutContext context)
        {
            _context = context;
        }

        Item IItemRepository.FindByItemId(int itemId)
        {
            return _context.Set<Item>().Find(itemId);
        }
    }
}
