using System;
using ZooResidents;
namespace ZooResidents;

//Животное в зоопарке описывается на основе следующих параметров:
public class Elephant
{
    //Свойства класса
    //Общее описание вида:

    //Описание конкретного животного:
    //Имя(Петя, Симба, Матильда)
    //private string _name;
    public string Name { get; set; }

    //Возраст(5, 1, 20)
    public int Age { get; private set; }
    private const int _age = 1;

    //Необходимый биом(Тропики, Тундра, Пустыня)
    //private string _type;
    public string Type { get; set; }

    //Необходимая площадь на особь(10 м^2)
    //private string _square;
    public string Square { get; private set; }
    private const int _square = 100;

    //Что кушает(Рыба, Мясо, Сено)
    public string Ration { get; set; }
    public string BadRation { get; set; }
    public int RationMass { get; set; }
    public bool RationFlag { get; set; }
    private static string[] _ration = { "Hay","Banan","Grass" };


    //Хищник или травоядное
    //private string _predatorOrHerbivore;
    public string PredatorOrHerbivore { get; set; }

    //Голоч (Ауф, Хрю, Рррр)
    //private string _voice;
    public string Voice { get; set; }

    //Объем потребляемой в сутки еды (5кг, 0.3кг)
    //private string _appetite;
    public double Appetite { get; set; }

    public Elephant(string type, string name, int age, int rationMass, string[] array)
    {
        Type = type;
        Name = name;

        if (rationMass <= 0)
        {
            RationMass = 0;
            //throw new ArgumentException("rationMass <= 0");
        }

        else
        {
            RationMass = rationMass;
        }

        if (age > 0 && age < 100)
        {
            Age = age;
        }

        else
        {
            Age = _age;
            throw new ArgumentException("a < 0 || a > 100");
        }

        string tmp = "... ";
        bool tmpFlag = false;

        for (int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < _ration.Length; j++)
            if (array[i] == _ration[j])
            {
                tmp += array[i] + " ";
                tmpFlag = true;

            }
        }
        Ration = "eat " + tmp;
        RationFlag = tmpFlag;
        string tmpBad = "";
        if(RationFlag == false)
        {
            for(int n = 0; n < array.Length; n++)
            {
                tmpBad += array[n] + " ";
            }
        }
        BadRation = tmpBad;

    }

    //  Метод класса
    //Есть
    public void ToEat()
    {
        if (RationFlag == false)
        {
            Console.WriteLine($"{Type} {Name} do not want eating {BadRation}");
        }

        else
        {
            Console.WriteLine($"{Type} {Name} received {RationMass}kg. of food and {Ration}");
        }

    }

    public void ToQuantityEat()
    {
        if (RationMass <= 5)
        {
            Console.WriteLine($"{Type} {Name} is hungry");
        }

        else
        {
            Console.WriteLine($"{Type} {Name} satisfied");
        }
    }

    //Издать звук
    public void DoVoice()
    {
        Console.WriteLine($"{Type} {Name} make sounds: {Voice}");
    }

    //Играть
    public void Play()
    {
        Console.WriteLine($"{Type} {Name} is play");
    }

}

