namespace Animals
{
    public class GoatAnimal: AbstractAnimals
    {
        public GoatAnimal(string name, int age, string biom, string typeFeed)
        {
            NameAnimal = name;
            _typeAnimal = "Goat";
            Age = age;
            Biom = biom;
            typeFeeding = typeFeed;
            _rationType = "seed";
            _sizeFullnessFeeding = 2;
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_typeAnimal}-{NameAnimal}: MeeeE");
        }
    }
}