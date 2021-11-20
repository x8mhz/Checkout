using Checkout.Domain.Entities;

namespace Checkout.Domain.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Item FindByItemId(int ItemId);
    }
}
