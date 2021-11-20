using System;
using System.Collections.Generic;

namespace Checkout.Domain.Entities
{
    public class Order
    {

        public Order(string document, DateTime issueDate, int seguence = 1)
        {
            Id = Guid.NewGuid();
            Document = new Document(document);
            OrderItems = new List<OrderItem>();
            Freight = 0;
            Sequence = 1;
            Code = new OrderCode(issueDate, seguence);
        }

        public Guid Id { get; private set; }
        public Document Document { get; private set; }
        public DateTime IssueDate { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }
        public int Sequence { get; private set; }
        public int Freight { get; private set; }
        public OrderCode Code { get; private set; }

        public void AddItem(Item item, int quantity)
        {
            OrderItems.Add(new OrderItem(item.ItemId, item.Price, quantity));
        }
    }
}
