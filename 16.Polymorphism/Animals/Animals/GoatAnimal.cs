using Animals.Options;

namespace Animals
{
    public class GoatAnimal: AbstractAnimals
    {
        public GoatAnimal(string name, int age, string typeFeed)
        {
            NameAnimal = name;
            TypeAnimal = "Goat";
            Age = age;
            Biom = BiomeType.Desert;
            Feeding = FeedingType.Herbivore;
            _rationType = "seed";
            SizeAnimalFullnessFeeding = 2;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{TypeAnimal}-{NameAnimal}: MeeeE");
        }
    }
}