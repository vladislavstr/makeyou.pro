using System;
using System.Text.Json;

namespace BookingSystem
{
    public class Book
    {
        public string PathTablesDict { get; set; }
        public string PathStatusOfReservation { get; set; }
        public string PathFreeTablesDict { get; set; }
        public string PathBookDict { get; set; }
        public Dictionary<int, Table> TablesDict { get; set; }
        public Dictionary<int, Order> OrdersDict { get; set; }

        public Dictionary<int, Table> FreeTablesDict { get; set; }
        public Dictionary<Order, int> BookDict { get; set; }
        //public Dictionary<Tuple<int, int>, List<string>> BookDict { get; set; }

        public Book()
        {
            TablesDict = new Dictionary<int, Table>();
            OrdersDict = new Dictionary<int, Order>();
            FreeTablesDict = new Dictionary<int, Table>();
            BookDict = new Dictionary<Order, int>(); ;
            //BookDict = new Dictionary<Tuple<int, int>, List<string>>(); ;

            PathFreeTablesDict = @"../../../FreeTablesList.txt";
            PathTablesDict = @"../../../TablesList.txt";
            PathStatusOfReservation = @"../../../StatusOfReservation.txt";
            PathBookDict = @"../../../Booking.txt";
        }

        public void SaveTablesList()
        {
            using (StreamWriter StreamWriterTablesList = new StreamWriter(PathTablesDict))
            {
                string JsonTablesLis = JsonSerializer.Serialize(TablesDict);
                StreamWriterTablesList.WriteLine(JsonTablesLis);
            }
        }

        public void SaveFreeTablesList()
        {
            using (StreamWriter StreamWriterFreeTablesList = new StreamWriter(PathFreeTablesDict))
            {
                string JsonFreeTablesLis = JsonSerializer.Serialize(FreeTablesDict);
                StreamWriterFreeTablesList.WriteLine(JsonFreeTablesLis);
            }
        }

        public void SaveRequestsForReservation()
        {
            using (StreamWriter StreamWriterStatusOfReservation = new StreamWriter(PathStatusOfReservation))
            {
                string JsonStatusOfReservation = JsonSerializer.Serialize(OrdersDict);
                StreamWriterStatusOfReservation.WriteLine(JsonStatusOfReservation);
            }
        }
        public void SaveBookDict()
        {
            using (StreamWriter StreamWriterBookDict = new StreamWriter(PathBookDict))
            {
                string JsonStatusOfReservation = JsonSerializer.Serialize(OrdersDict);
                StreamWriterPathStatusOfReservation.WriteLine(JsonStatusOfReservation);
            }


            public void LoadAll()
        {
            if (File.Exists(PathTablesDict))
            {
                using (StreamReader StreamWriterTablesDict = new StreamReader(PathTablesDict))
                {
                    string JsonTablesDict = StreamWriterTablesDict.ReadLine()!;
                    TablesDict = JsonSerializer.Deserialize<Dictionary<int, Table>>(JsonTablesDict)!;
                }
            }

            if (File.Exists(PathFreeTablesDict))
            {
                using (StreamReader StreamWriterFreeTablesDict = new StreamReader(PathFreeTablesDict))
                {
                    string JsonFreeTablesDict = StreamWriterFreeTablesDict.ReadLine()!;
                    FreeTablesDict = JsonSerializer.Deserialize<Dictionary<int, Table>>(JsonFreeTablesDict)!;
                }
            }

            if (File.Exists(PathStatusOfReservation))
            {
                using (StreamReader StreamWriterPathStatusOfReservation = new StreamReader(PathStatusOfReservation))
                {
                    string JsonStatusOfReservation = StreamWriterPathStatusOfReservation.ReadLine()!;
                    OrdersDict = JsonSerializer.Deserialize<Dictionary<int, Order>>(JsonStatusOfReservation)!;
                }
            }
        }
    }
}