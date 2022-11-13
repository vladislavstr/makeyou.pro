namespace Animals
{
    public class CatAnimal : AbstractAnimals
    {
        public CatAnimal(string name, int age)
        {
            Name = name;
            _type = "Cat";
            _rationType = "fish";
            Age = age;
        }

        public override void Drink()
        {
            Console.WriteLine($"{_type}-{Name}: drinking from plate");
        }

        public override void DoVoice()
        {
            Console.WriteLine($"{_type}-{Name}: meows");
        }

        public void Jump()
        {
            Console.WriteLine($"{_type}-{Name}: jumped up a tree");
        }
    }
}