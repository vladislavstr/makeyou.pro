using System;
using System.Text.Json;

namespace BookingSystem
{
    public class Book
    {
        public string PathTablesDict { get; set; }
        public string PathStatusOfReservation { get; set; }

        public Dictionary<int, Table> TablesDict { get; set; }
        public Dictionary<int, Order> OrdersDict { get; set; }

        public Book()
        {
            TablesDict = new Dictionary<int, Table>();
            OrdersDict = new Dictionary<int, Order>();
            PathTablesDict = @"../../../TablesList.txt";
            PathStatusOfReservation = @"../../../StatusOfReservation.txt";
        }
        public void SaveTablesList()
        {
            using (StreamWriter StreamWriterTablesList = new StreamWriter(PathTablesDict))
            {
                string JsonTablesLis = JsonSerializer.Serialize(TablesDict);
                StreamWriterTablesList.WriteLine(JsonTablesLis);
            }
        }

        public void SaveRequestsForReservation()
        {
            using (StreamWriter StreamWriterPathStatusOfReservation = new StreamWriter(PathStatusOfReservation))
            {
                string JsonStatusOfReservation = JsonSerializer.Serialize(OrdersDict);
                StreamWriterPathStatusOfReservation.WriteLine(JsonStatusOfReservation);
            }
        }

        public void LoadAll()
        {
            if (File.Exists(PathTablesDict))
            {
                using (StreamReader StreamWriterTablesDict = new StreamReader(PathTablesDict))
                {
                    string JsonTablesDict = StreamWriterTablesDict.ReadLine()!;
                    TablesDict = JsonSerializer.Deserialize<Dictionary<int, Table>>(JsonTablesDict)!;
                    Console.WriteLine("");
                }
            }

            if (File.Exists(PathStatusOfReservation))
            {
                using (StreamReader StreamWriterPathStatusOfReservation = new StreamReader(PathStatusOfReservation))
                {
                    string JsonStatusOfReservation = StreamWriterPathStatusOfReservation.ReadLine()!;
                    OrdersDict = JsonSerializer.Deserialize<Dictionary<int, Order>>(JsonStatusOfReservation)!;
                    Console.WriteLine("");
                }
            }
        }
    }
}

//