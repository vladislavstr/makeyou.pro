using BookingSystem;
using BookingSystem.Tests.TestCaseSources;
using System.IO;
using System.Text.Json;

namespace BookingSystem.Tests
{
    public class BookTests
    {

        private string _pathFreeTablesDict = @"../../../TestFreeTablesList.txt";
        private string _pathTablesDict = @"../../../TestTablesList.txt";
        private string _pathStatusOfReservation = @"../../../TestStatusOfReservation.txt";
        private string _pathBookDict = @"../../../TestBooking.txt";
        private Book _book;

        [SetUp]
        public void SeyUp()
        {
            _book = new Book();

            _book.PathFreeTablesDict = _pathFreeTablesDict;
            _book.PathTablesDict = _pathTablesDict;
            _book.PathStatusOfReservation = _pathStatusOfReservation;
            _book.PathBookDict = _pathBookDict;

        }

        [TestCaseSource(typeof(LoadAllTestCaseSource))]
        public void LoadAllTest(Table tables, Order orders )
        {
            using (StreamReader StreamWriterTablesDict = new StreamReader(_pathTablesDict))
            {
                string JsonTablesDict = StreamWriterTablesDict.ReadLine()!;
                tablesDict = JsonSerializer.Deserialize<Dictionary<int, Table>>(JsonTablesDict)!;
            }
            using (StreamReader StreamWriterFreeTablesDict = new StreamReader(_pathFreeTablesDict))
            {
                string JsonFreeTablesDict = StreamWriterFreeTablesDict.ReadLine()!;
                freeTablesDict = JsonSerializer.Deserialize<Dictionary<int, Table>>(JsonFreeTablesDict)!;
            }
            using (StreamReader StreamWriterPathStatusOfReservation = new StreamReader(_pathStatusOfReservation))
            {
                string JsonStatusOfReservation = StreamWriterPathStatusOfReservation.ReadLine()!;
                ordersDict = JsonSerializer.Deserialize<Dictionary<int, Order>>(JsonStatusOfReservation)!;
            }
            using (StreamReader StreamWriterBookDict = new StreamReader(_pathBookDict))
            {
                string JsonStatusOfReservation = StreamWriterBookDict.ReadLine()!;
                bookDict = JsonSerializer.Deserialize<Dictionary<Order, int>>(JsonStatusOfReservation)!;
            }

            _book.PathFreeTablesDict = path;
            _book.PathTablesDict = path;
            _book.PathStatusOfReservation = path;
            _book.PathBookDict = path;

            _book.LoadAll();

            Dictionary<int, Table> expectedTables = tables;
            Dictionary<int, Table> actualTables = _book.TablesDict;

            Assert.AreEqual(expectedTables, actualTables);

            Dictionary<int, Order> expectedOrders = orders;
            Dictionary<int, Order> actualOrders = _book.OrdersDict;

            Assert.AreEqual(expectedOrders, actualOrders);
        }
    }
}