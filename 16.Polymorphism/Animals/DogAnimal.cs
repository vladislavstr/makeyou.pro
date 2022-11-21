namespace Animals
{
    public class DogAnimal : AbstractAnimals
    {
        public DogAnimal(string name, int age, string biom, string typeFeed)
        {
            NameAnimal = name;
            _typeAnimal = "Dog";
            Age = age;
            Biom = biom;
            typeFeeding = typeFeed;
            _rationType = "meat";
            _sizeFullnessFeeding = 3;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_typeAnimal}-{NameAnimal}: barks");
        }
    }
}