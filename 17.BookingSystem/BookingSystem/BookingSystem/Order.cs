using System;
namespace BookingSystem
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int AmounteOfPersone { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, string customer, int amount, DateTime date)
        {
            Id = id;
            CustomerName = customer;
            AmounteOfPersone = amount;
            Date = date;
        }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   Id == order.Id &&
                   CustomerName == order.CustomerName &&
                   AmounteOfPersone == order.AmounteOfPersone &&
                   Date == order.Date;
        }
    }
}

