using System;
namespace BookingSystem
{
    public class Administrator
    {
        private Book _book;
        //private Table _table;
        //private Order _order;

        public Administrator()
        {
            _book = new Book();
            _book.LoadAll();
            //_book.SaveTablesList();
            //_book.SaveRequestsForReservation();
            //_book.SaveRequestsForReservation();
        }

        public void AddTable(Table table)
        {
            _book.TablesDict.Add(table.TableNumber, table);
            _book.SaveTablesList();
        }

        public void RemoveTable(int number)
        {
            _book.TablesDict.Remove(number);
            _book.SaveTablesList();
        }

        public void AddOrder(Order order)
        {
            _book.OrdersDict.Add(order.OrderNumber, order);
            _book.SaveRequestsForReservation();
        }

        public void RemoveOrder(int number)
        {
            _book.OrdersDict.Remove(number);
            _book.SaveRequestsForReservation();
        }

        public void AddBooking(Order order, Table table)
        {
            if (table.TableSize >= order.AmounteOfPersone)
            {
                _book.BookDict.Add(order, table.TableNumber);
                _book.SaveBookDict();
            }
            else
            {
                Console.WriteLine($"Table size: {table.TableSize} < amounte of persone: {order.AmounteOfPersone}");
            }
        }
        //public List<Order> GetOrdersByTableName(int Number)
        //{
        //    List<Order> orders = new List<Order>();

        //    foreach (Order order in _book.Orders)
        //    {
        //        if (order.TableNumber == Num)
        //        {
        //            orders.Add(order);
        //        }
        //    }

        //    return orders;
        //}
    }
}

