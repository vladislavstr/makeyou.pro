using System;
namespace BookingSystem
{
    public class Table
    {
        public byte TableNumber { get; set; }
        public int TableSize { get; private set; }

        public Table(byte number, int sise)
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

//