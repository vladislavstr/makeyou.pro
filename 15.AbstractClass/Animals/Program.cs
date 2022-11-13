//-Опишите класс животного как абстракцию

//-Добавьте минимум 3 класса конкретных животных, реализующих абстракцию, автоматически заполняющие часть полей (тип, что есть и тд)

//-Дополните конкретных животных методами игры со своими сородичами и особым функционалом (птицы умеют летать, приматы - лазить по деревьям) 

//В итоге должна получиться структура животных объединенных общей абстракцией.


using Animals;

DogAnimal dog = new DogAnimal("Sobaka", 2);
BirdAnimal bird = new BirdAnimal("Ptica", 4);
CatAnimal cat = new CatAnimal("Coshka", 7);

AbstractAnimals[] animalsArray = new AbstractAnimals[] {dog, cat, bird};

for (int i = 0; i < animalsArray.Length; i++)
{
    animalsArray[i].Drink();
    animalsArray[i].WriteRation();
    animalsArray[i].DoVoice();

    Console.WriteLine();
}

Console.WriteLine();

bird.Fly();
cat.Jump();
dog.Eat("fish");
dog.Eat("meat");