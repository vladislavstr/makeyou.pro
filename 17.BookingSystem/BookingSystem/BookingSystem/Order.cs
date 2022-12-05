using System;
namespace BookingSystem
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTelephoneNmber { get; set; }
        public int AmounteOfPersone { get; set; }
        public DateTime Date { get; set; }

        public Order(int id, string customer, string number, int amount, DateTime date)
        {
            OrderNumber = id;
            CustomerName = customer;
            CustomerTelephoneNmber= number;
            AmounteOfPersone = amount;
            Date = date;
        }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   OrderNumber == order.OrderNumber &&
                   CustomerName == order.CustomerName &&
                   AmounteOfPersone == order.AmounteOfPersone &&
                   Date == order.Date;
        }
    }
}