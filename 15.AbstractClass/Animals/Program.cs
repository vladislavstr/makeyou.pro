using Animals;

DogAnimal dog = new DogAnimal("Sobaka");
BirdAnimal bird = new BirdAnimal("Ptica");
TortoiseAnimal tortoise = new TortoiseAnimal("Cherepaha");

AbstractAnimal[] A = new AbstractAnimal[]
{
    dog, bird, tortoise
};

for (int i = 0; i < 3; i++)
{
    A[i].Drink();
}

Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    A[i].Eat();
}

Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    A[i].Sleep();
}

Console.WriteLine();

dog.Play();
bird.Fly();
tortoise.Swim();

