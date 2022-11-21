//Добавьте класс вольера, в котором живут животные и который описывается следующим функционалом:
//    Параметры;
//-Название
//- Биом
//- Площадь

//Функциональность:
//-Может содержать в себе различных животных
//        -Можно подселить животное
//        -Можно отселить животное
//        -Можно покормить животных (еда "насыпается" в вольер сразу всем, а не конкретному животному)
//        -Можно узнать сколько и какой еды осталось в кормушках
//        -Можно узнать кто не наелся, сколько и какой еды им нужно
//        -Можно попросить всех животных издать звук

//    Правила расселения:
//        -Животное можно поселить только в вольер, который соответствует его биому и в котором достаточно свободного места.
//        -Хищники могут жить только с представителями того же вида.
//        -Травоядные могут жить с любыми травоядными

using System.Drawing;

namespace Animals
{
	public class Aviary
	{
        private const int _sizeAviaryConst = 1;
        private readonly string[] _biomAviaryArray = { "sea", "forest", "field" };
        private readonly string[] _typeFeedingAviaryArray = { "meat-eater", "herbivore" }; // чтобы не забыть. не понял как перетянуть модификатор readonli из класса abstractAnimals без насдедования.

        private int _sizeAviary;
        private string _biomAviary;
        private string _typeFeedingAviary;
        DateTime dateTime = new DateTime();

        private string NameAviary { get; set; }
        public object[] NewAviary { get; set; }

        private string BiomAviary
        {
            get
            {
                return _biomAviary;
            }
            set
            {
                
                for (int i = 0; i < _biomAviaryArray.Length; i++)
                {
                    if (value == _biomAviaryArray[i])
                    {
                        _biomAviary = value;
                        break;
                    }
                    else
                    {
                        _biomAviary = "NaN";
                    }
                }
            }
        }

        private string FeedingAviary 
        {
            get
            {
                return _typeFeedingAviary;
            }
            set
            {
                for (int i = 0; i < _typeFeedingAviaryArray.Length; i++)
                {
                    if (value == _typeFeedingAviaryArray[i])
                    {
                        _typeFeedingAviary = value;
                        break;
                    }
                    else
                    {
                        _typeFeedingAviary = "NaN";
                    }
                }
            }
        }

        private int SizeAviary
        {
            get
            {
                return _sizeAviary;
            }
            set
            {
                if (value > 0 && value < 10)
                {
                    _sizeAviary = value;
                }
                else
                {
                    _sizeAviary = _sizeAviaryConst;
                    throw new ArgumentException("size aviary < 0 || size aviary > 10");
                }
            }
        }

        public Aviary(string name, string biom, string typeFeeding, int size)
		{
            NameAviary = name;
            BiomAviary = biom;
            FeedingAviary = typeFeeding;
            SizeAviary = size;
            dateTime = DateTime.Now.Date;

            NewAviary = new object[SizeAviary];
            Array.Fill<object>(NewAviary, new NaNAnimal());// заполним созданный массив 0-ми 
        }
        
        public void WriteInfoAviary()
        {
            Console.WriteLine($"{NameAviary}:");
            Console.WriteLine($"boim is - {BiomAviary}");
            Console.WriteLine($"type feeding - {FeedingAviary}");
            Console.WriteLine($"ration in this aviary - {SizeAviary}");
            Console.WriteLine($"date created - {dateTime}");
        }

        public void DoSettlingAnimalToAviary(AbstractAnimals addAnimal)
        {
            for(int i = 0; i < NewAviary.Length; i++)
            {
                
                if (NewAviary[i].)

                if (BiomAviary == addAnimal._biomAnimal)
                {
                    NewAviary[i] = addAnimal;

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"The animal {addAnimal.NameAnimal} is in {NameAviary} aviary");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The animal {addAnimal.NameAnimal} can not living in {NameAviary} aviary");
                    Console.WriteLine($"The animal Biom {addAnimal._biomAnimal} != Biom aviary {BiomAviary} ");
                    Console.ResetColor();
                }
            }
            
        }
    }
}