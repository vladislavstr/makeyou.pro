using System;
using ZooResidents;
namespace ZooResidents;

public class Animal
{
    private const int _ageConst = 1;
    private int _age;
    private int _amountFoodEaten = 0;

    private string _rationCat = "fish";
    private int _tationMassCat = 5;
    private string _voiceCat = "Miau";

    public string Type { get; set; }
    public string Name { get; set; }
    public string Ration { get; set; }
    public int RationMass { get; set; }
    public string Voice { get; set; }
    public int Age
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


    public Animal(string type, string name, int age, string ration, int rationMass, string voice)
    {
        Type = type;
        Name = name;
        Age = age;
        Ration = ration;
        RationMass = rationMass;
        Voice = voice;
        
    }

    public Animal(string type, string name, int age)
    {
        Name = name;
        Age = age;

        if(type == "Cat")
        {
            Type = type;
            Ration = _rationCat;
            RationMass = _tationMassCat;
            Voice = _voiceCat;
        }
    }

    public void ToEat(string food, int massFood)
    {
        if (food == Ration)
        {
            _amountFoodEaten += massFood;
            Console.WriteLine($"{Type} {Name} received {massFood}kg. of the {food}");
        }

        else
        {
            Console.WriteLine($"{Type} {Name} do not want eating the {food}");
        }

    }

    public void ToQuantityEat()
    {
        if (_amountFoodEaten < RationMass)
        {
            Console.WriteLine($"{Type} {Name} is hungry");
        }

        else
        {
            Console.WriteLine($"{Type} {Name} is satisfied");
        }

    }


    public void DoVoice()
    {
        Console.WriteLine($"a {Age}- year- old {Type} {Name} make a sounds: {Voice}");

    }

}

