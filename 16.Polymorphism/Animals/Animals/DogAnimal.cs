using Animals.Options;

namespace Animals
{
    public class DogAnimal : AbstractAnimals
    {
        public DogAnimal(string name, int age, string typeFeed)
        {
            NameAnimal = name;
            TypeAnimal = "Dog";
            Age = age;
            Biom = BiomeType.Desert;
            Feeding = FeedingType.MeatEater;
            _rationType = "meat";
            SizeAnimalFullnessFeeding = 3;
            statusObj = 1;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{TypeAnimal}-{NameAnimal}: barks");
        }
    }
}