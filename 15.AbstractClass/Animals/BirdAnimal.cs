using System;
using System.Xml.Linq;

namespace Animals
{
    public class BirdAnimal: AbstractAnimals
    {
        public BirdAnimal()
        {
            Name = name;
            _type = "Bird";
        }

        public override void Eat()
        {
            Console.WriteLine($"{_type}-{Name}: pecking grain");
        }
        public override void Drink()
        {
            Console.WriteLine($"{_type}-{Name}: Попил дождевой воды");
        }

        public void Fly()
        {
            Console.WriteLine($"{_type}-{Name}: Полетал");
        }
    }
}

