using System;
using System.Collections;
using System.Text.Json;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using BookingSystem;
namespace BookingSystem.Tests.TestCaseSources
{
    public class LoadAllTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Table table1 = new Table(1, 1);
            Order order1 = new Order(1111, "AAA", "8 (000) 000 00 00", 1, new DateTime(2022, 6, 11));

            Dictionary<int, Table> tablesDict = new Dictionary<int, Table>();
            tablesDict[0] = table1;
            Dictionary<int, Order> ordersDict = new Dictionary<int, Order>();
            ordersDict[0] = order1;
            Dictionary<int, Table> freeTablesDict = new Dictionary<int, Table>();
            freeTablesDict[0] = table1;
            Dictionary<Order, int> bookDict = new Dictionary<Order, int>();
            bookDict[order1] = 0;
            yield return new Object[] { tablesDict, ordersDict, freeTablesDict, bookDict };

            yield return new Object[]
            {
                new Dictionary<int, Table>(),
                new Dictionary<int, Order>(),
                new Dictionary<int, Table>(),
                new Dictionary<Order, int>()
            };

            //throw new NotImplementedException();
        }
    }
}
