namespace Animals
{
    public abstract class AbstractAnimals
    {
        public const int _ageConst = 1;
        private readonly string[] _biomArray = { "sea", "forest", "field" };
        private readonly string[] _typeFeedingArray = { "meat-eater", "herbivore" };

        protected string _nameAnimal;
        protected string _biomAnimal;
        protected string _typeAnimal;
        protected string _rationType;
        protected int _age;
        protected string _typeFeeding;
        protected bool _statusFullnessFeeding = false;
        protected int _sizeFullnessFeeding;

        protected string typeFeeding
        {
            get
            {
                return _typeFeeding;
            }
            set
            {
                for (int i = 0; i < _typeFeedingArray.Length; i++)
                {
                    if (value == _typeFeedingArray[i])
                    {
                        _typeFeeding = value;
                        break;
                    }
                    else
                    {
                        _typeFeeding = "NaN";
                    }
                }
            }
        }

        protected string Biom
        {
            get
            {
                return _biomAnimal;
            }
            set
            {
                for (int i = 0; i < _biomArray.Length; i++)
                {
                    if(value == _biomArray[i])
                    {
                        _biomAnimal = value;
                        break;
                    }
                    else
                    {
                        _biomAnimal = "NaN";
                    }
                }
            }
        }

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
                Console.WriteLine($"{_typeAnimal}-{_nameAnimal} do not want eats the {food}");
                if(_statusFullnessFeeding == false)
                {
                    Console.WriteLine($"asks for food");
                }
                else
                {
                    Console.WriteLine($"satisfied");
                }
            }
            else
            {
                Console.WriteLine($"{_typeAnimal}-{_nameAnimal} eats {food}");
            }
        }

        public void Writeinfo()
        {
            Console.WriteLine($"{_typeAnimal}- {_nameAnimal} {Age} years old:");
            Console.WriteLine($"boim is {Biom}");
            Console.WriteLine($"type feeding {typeFeeding}");
            Console.WriteLine($"ration is {_rationType} {_sizeFullnessFeeding} kg. on day.");
        }

        public abstract void DoVoice();
    }
}