using System;
namespace BookingSystem
{
    public class Table
    {
        public int TableNumber { get; set; }
        public int TableSize { get; private set; }

        public Table(int number, int sise)
        {
            TableNumber = number;
            TableSize = sise;
        }


        public override bool Equals(object? obj)
        {
            return obj is Table table &&
                   TableNumber == table.TableNumber &&
                   TableSize == table.TableSize;
        }
    }
}