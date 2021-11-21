using System;

namespace Checkout.Domain.Entities
{
    public class OrderCode
    {
        protected OrderCode()
        {

        }

        public OrderCode(DateTime date, int sequence)
        {
            Date = date;

            if (!sequence.Equals(typeof(int))) throw new Exception("Invalid parameter");
            var year = date.Year;
            var sequence8Char = Convert.ToString(sequence).PadLeft(8);

            Sequence = Convert.ToInt32(year + sequence8Char);
        }

        public DateTime Date { get; set; }
        public int Sequence { get; set; }
    }
}
