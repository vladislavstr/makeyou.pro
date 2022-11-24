namespace Animals
{
    public class CowAnimal : AbstractAnimals
    {
        public CowAnimal(string name, int age, string biom, string typeFeed)
        {
            NameAnimal = name;
            _typeAnimal = "Cow";
            Age = age;
            Biom = biom;
            typeFeeding = typeFeed;
            _rationType = "seed";
            _sizeFullnessFeeding = 6;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_typeAnimal}-{NameAnimal}: Mu-Mu");
        }

    }
}