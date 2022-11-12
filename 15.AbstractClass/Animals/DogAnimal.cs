using System;
using Animals;
using System.Data;
using System.Xml.Linq;

namespace Animals
{
    public class DogAnimal : AbstractAnimals
    {
        public DogAnimal(string name)
        {
            Name = name;
            _type = "Bird";
        }

        public override void Eat()
        {
            Console.WriteLine($"{_type}-{Name}: ест");
        }
        public override void Drink()
        {
            Console.WriteLine($"{_type}-{Name}: пьет");
        }

        public void DoVoice()
        {
            Console.WriteLine($"{_type}-{Name}: гавкает");
        }
    }
}