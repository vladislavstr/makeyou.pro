namespace Animals
{
    public abstract class AbstractAnimals
    {
        public const int _ageConst = 1;

        protected string Name { get; set; }
        protected string _eat;
        protected string _type;
        protected string _rationType;
        protected int _age;

        protected int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    _age = _ageConst;
                    throw new ArgumentException("a < 0 || a > 100");
                }
            }
        }

        public  void WriteRation()
        {
            Console.WriteLine($"{_type}-{Name} {Age} years old: ration is {_rationType}");
        }

        public virtual void Eat(string _eat)
        {
            if (_rationType != _eat)
            {
                Console.WriteLine($"{_type}-{Name} {Age} do not want eats the {_eat}");
            }
            else
            {
                Console.WriteLine($"{_type}-{Name} eats {_eat}");
            }
        }

        public abstract void Drink();
        public abstract void DoVoice();
    }
}