using BookingSystem;
using System.Text.Json;

Table table1 = new Table(1, 2);
Table table2 = new Table(2, 2);

Order order1 = new Order(1, "Vova", 1, new DateTime(2022, 5, 10));
Order order2 = new Order(1, "Max", 5, new DateTime(2022, 6, 11));


Administrator admin = new Administrator();

admin.AddTable(table1);
admin.AddTable(table1);

admin.AddOrder(order1);

//Dictionary<string, string> d=new Dictionary<string, string>();
//d.Add("q", "qweqwe");
//d.Add("w", "qqqqqqq");
////d.Clear();
////d.Remove("w");
////////////string s="123456";
////////////d.TryGetValue("w", out s);
//d.ContainsKey("w");

//foreach (KeyValuePair<string,string> i in d)
//{
//    i.Value;
//    i.Key;
//}

//Console.WriteLine(d["w"]);

//int[] a = new int[10];
//for (int i = 0; i < a.Length; i++)
//{
//    //a[i];
//}

//foreach (int i in a)
//{

//}