using System;
namespace BookingSystem
{
    public class Administrator
    {
        private Book _book;
        private Table _table;
        private Order _order;

        public Administrator()
        {
            _book = new Book();
            _book.SaveTablesList();
            _book.SaveRequestsForReservation();
        }

        public void AddTable(Table table)
        {
            _book.TablesDict.Add(_table.TableNumber, _table);
            _book.SaveTablesList();
        }

        public void AddOrder(Order order)
        {
            _book.OrdersDict.Add(_order.Id, _order);
            _book.SaveRequestsForReservation();
        }

        public List<Order> GetOrdersByTableName(int Number)
        {
            List<Order> orders = new List<Order>();

            foreach (Order order in _book.Orders)
            {
                if (order.TableNumber == Num)
                {
                    orders.Add(order);
                }
            }

            return orders;
        }
    }
}

