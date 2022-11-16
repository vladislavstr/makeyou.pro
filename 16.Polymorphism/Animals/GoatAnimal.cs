namespace Animals
{
    public class GoatAnimal: AbstractAnimals
    {
        public GoatAnimal(string name, int age, string biom, string typeFeed)
        {
            _nameAnimal = name;
            _typeAnimal = "Goat";
            Age = age;
            Biom = biom;
            typeFeeding = typeFeed;
            _rationType = "seed";
            _sizeFullnessFeeding = 2;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_typeAnimal}-{_nameAnimal}: MeeeE");
        }
    }
}