namespace Animals
{
    public class BirdAnimal: AbstractAnimals
    {
        public BirdAnimal(string name, int age)
        {
            Name = name;
            _type = "Bird";
            _rationType = "corn";
            Age = age;
        }

        public override void Drink()
        {
            Console.WriteLine($"{_type}-{Name}: drinking");
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_type}-{Name}: tweets");
        }

        public void Fly()
        {
            Console.WriteLine($"{_type}-{Name}: flying");
        }
    }
}