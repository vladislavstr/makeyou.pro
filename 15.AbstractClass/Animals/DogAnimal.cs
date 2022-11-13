namespace Animals
{
    public class DogAnimal : AbstractAnimals
    {
        public DogAnimal(string name, int age)
        {
            Name = name;
            _type = "Dog";
            _rationType = "meat";
            Age = age;
        }

        public override void Drink()
        {
            Console.WriteLine($"{_type}-{Name}: drinking from lake");
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_type}-{Name}: barks");
        }
    }
}