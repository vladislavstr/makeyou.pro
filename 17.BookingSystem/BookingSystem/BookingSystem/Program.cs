using BookingSystem;
using System.Text.Json;

Table table1 = new Table(1, 2);
Table table2 = new Table(2, 2);

Order order1 = new Order(1111, "Vova", "8 (905) 777 77 77",1, new DateTime(2022, 5, 10));
Order order2 = new Order(2222, "Max", "8 (905) 888 88 88", 5, new DateTime(2022, 6, 11));


Administrator admin = new Administrator();

admin.AddTable(table1);
admin.AddTable(table2);

admin.AddOrder(order1);
admin.AddOrder(order2);

admin.RemoveTable(table1.TableNumber);
admin.RemoveOrder(order1.OrderNumber);