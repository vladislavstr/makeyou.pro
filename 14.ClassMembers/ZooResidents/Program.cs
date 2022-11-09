using ZooResidents;

Animal Animal_1 = new Animal("Slon", "Petr", 10, "Banan", 20, "Uhu");
Animal_1.ToEat("Banan", 1);
Animal_1.ToQuantityEat();
Animal_1.ToEat("Meat", 1);
Animal_1.ToEat("Banan", 20);
Animal_1.ToQuantityEat();
Animal_1.DoVoice();
Console.WriteLine();

Animal Animal_2 = new Animal("Cat", "Barsik", 4);
Animal_2.ToEat("Banan", 1);
Animal_2.ToQuantityEat();
Animal_2.ToEat("fish", 1);
Animal_2.ToQuantityEat();
Animal_2.ToEat("fish", 5);
Animal_2.ToQuantityEat();
Animal_2.DoVoice();