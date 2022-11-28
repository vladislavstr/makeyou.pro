using Animals.Options;

namespace Animals
{
    public abstract class AbstractAnimals
    {
        private const int _ageConst = 1;

        public byte statusObj;
        public string _rationType;
        private int _age;
        protected bool _statusFullnessFeeding = false;

        public int SizeAnimalFullnessFeeding { get; protected set; }
        public string TypeAnimal { get; protected set; }
        public string NameAnimal { get; protected set; }
        public int SizeAnimal { get; protected set; }
        public FeedingType Feeding { get; protected set; }
        public BiomeType Biom { get; protected set; }

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

        public virtual void Eating(string food, int amountFood)
        {
            if (_rationType != food)
            {
                Console.WriteLine($"{TypeAnimal}-{NameAnimal} do not want eats the {food}");
            }
            else
            {
                Console.WriteLine($"{TypeAnimal}-{NameAnimal} eats {food}");
            }

            if (_statusFullnessFeeding == false)
            {
                Console.WriteLine($"asks for food");
            }
            else
            {
                Console.WriteLine($"satisfied");
            }
        }

        public void Writeinfo()
        {
            Console.WriteLine($"{TypeAnimal}- {NameAnimal} {Age} years old:");
            Console.WriteLine($"boim is {Biom}");
            Console.WriteLine($"type feeding {Feeding}");
            Console.WriteLine($"ration is {_rationType} {SizeAnimalFullnessFeeding} kg. on day.");
        }

        public virtual void DoVoice()
        {
            Console.WriteLine($"{TypeAnimal}-{NameAnimal}: barks");
        }
    }
}