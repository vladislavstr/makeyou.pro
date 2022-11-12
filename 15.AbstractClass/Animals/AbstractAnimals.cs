namespace Animals
{
    public class AbstractAnimals
    {

        
        public string Name { get; set; }
        protected string _type;

        public abstract void Eat();
        public abstract void Drink();
        public abstract void DoVoice();

        public void BeHappy()
        {
            Console.WriteLine($"{_type}-{Name}: rejoices");
        }

    }
}
