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
using Animals.Options;

namespace Animals
{
	public class Aviary
	{
        private const int _sizeAviaryConst = 1;

        private int _sizeAviary;
        private string _biomAviary;
        private string _typeFeedingAviary;
        DateTime dateTime = new DateTime();

        public string NameAviary { get; private set; }
        public BiomeType AviaryBiom { get; private set; }
        public FeedingType AviaryFeeding { get; private set; }

        public AbstractAnimals[] animals { get; private set; }

        

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

        public Aviary(string name, BiomeType biom, FeedingType feeding, int size)
		{
            NameAviary = name;
            AviaryBiom = biom;
            AviaryFeeding = feeding;
            SizeAviary = size;
            dateTime = DateTime.Now.Date;

            NewAviary = new object[SizeAviary];
        }
        
        public void WriteInfoAviary()
        {
            Console.WriteLine($"{NameAviary}:");
            Console.WriteLine($"boim is - {AviaryBiom}");
            Console.WriteLine($"type feeding - {AviaryFeeding}");
            Console.WriteLine($"ration in this aviary - {SizeAviary}");
            Console.WriteLine($"date created - {dateTime}");
        }

        public void DoSettlingAnimalToAviary(AbstractAnimals addAnimal)
        {
            for(int i = 0; i < NewAviary.Length; i++)
            {
                
                if (NameAviary[i].)

                if (AviaryBiom == addAnimal._biomAnimal)
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
                    Console.WriteLine($"The animal Biom {addAnimal._biomAnimal} != Biom aviary {AviaryBiom} ");
                    Console.ResetColor();
                }
            }
            
        }
    }
}