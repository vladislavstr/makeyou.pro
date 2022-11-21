using System.Data;
using Animals;

AbstractAnimals[] animal = new AbstractAnimals[3];

animal[0] = new DogAnimal("Pesik", 2, "forest", "meat-eater");
animal[1] = new GoatAnimal("Tagil", 4, "forest", "herbivore");
animal[2] = new CowAnimal("Burenka", 7, "field", "herbivore");

for (int i = 0; i < animal.Length; i++)
{
    animal[i].Writeinfo();
    Console.WriteLine();
}

animal[1].Eating("meat",8);
Console.WriteLine();

Aviary test = new Aviary("aquarium for predatory fish", "sea", "meat-eater", 2);
test.WriteInfoAviary();
Console.WriteLine();

test.DoSettlingAnimalToAviary(animal[0]);

