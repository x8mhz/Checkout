using System;

namespace Checkout.Domain.Entities
{
    public class OrderCode
    {
        public string value = string.Empty;
        public OrderCode(DateTime date, int sequence)
        {
            Id = Guid.NewGuid();    
            Date = date;
            Sequence = sequence;

            if (!sequence.Equals(typeof(int))) throw new Exception("Invalid parameter");
            var year = date.Year;
            var sequence8Char = Convert.ToString(sequence).PadLeft(8);

            value = Convert.ToString(year + sequence8Char);
        }

        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public int Sequence { get; private set; }
    }
}
