using Animals.Options;

namespace Animals
{
    public class CowAnimal : AbstractAnimals
    {
        public CowAnimal(string name, int age, string typeFeed)
        {
            NameAnimal = name;
            TypeAnimal = "Cow";
            Age = age;
            Biom = BiomeType.Desert;
            Feeding = FeedingType.Herbivore;
            _rationType = "seed";
            SizeAnimalFullnessFeeding = 6;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{TypeAnimal}-{NameAnimal}: Mu-Mu");
        }

    }
}