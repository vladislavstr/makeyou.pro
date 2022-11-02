using System;
namespace ZooResidents;

//Животное в зоопарке описывается на основе следующих параметров:
public class Animals
{
    //Свойства класса
    //Общее описание вида:

    //Описание конкретного животного:
    //Имя(Петя, Симба, Матильда)
    //private string _name;
    public string Name { get; set; }

    //Необходимый биом(Тропики, Тундра, Пустыня)
    //private string _type;
    public string Type { get; set; }

    //Необходимая площадь на особь(10 м^2)
    //private string _square;
    public string Square { get; set; }

    //Что кушает(Рыба, Мясо, Сено)
    //private string _ration;
    public string Ration { get; set; }

    //Хищник или травоядное
    //private string _predatorOrHerbivore;
    public string PredatorOrHerbivore { get; set; }

    //Голоч (Ауф, Хрю, Рррр)
    //private string _voice;
    public string Voice { get; set; }

    //Объем потребляемой в сутки еды (5кг, 0.3кг)
    //private string _appetite;
    public double Appetite { get; set; }

    //        Возраст(5, 1, 20)
    private int _age;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
    }


    //  Метод класса
    //Есть
    public void ToEat()
    {
        Console.WriteLine($"{Type} {Name} eating {Ration}");
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

