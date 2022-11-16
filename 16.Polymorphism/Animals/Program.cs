//-Опишите класс животного как абстракцию

//-Добавьте минимум 3 класса конкретных животных, реализующих абстракцию, автоматически заполняющие часть полей (тип, что есть и тд)

//-Дополните конкретных животных методами игры со своими сородичами и особым функционалом (птицы умеют летать, приматы - лазить по деревьям) 

//В итоге должна получиться структура животных объединенных общей абстракцией.


using Animals;

DogAnimal dog = new DogAnimal("Pesik", 2, "forest", "meat-eater");
GoatAnimal goat = new GoatAnimal("Tagil", 4, "field", "herbivore");
CowAnimal cow = new CowAnimal("Burenka", 7, "field", "herbivore");

AbstractAnimals[] animalsArray = new AbstractAnimals[] {dog, cow, goat};

for (int i = 0; i < animalsArray.Length; i++)
{
    animalsArray[i].Writeinfo();

    Console.WriteLine();
}

Console.WriteLine();

dog.Eating("fish",4);
dog.Eating("meat",8);

Console.WriteLine();
