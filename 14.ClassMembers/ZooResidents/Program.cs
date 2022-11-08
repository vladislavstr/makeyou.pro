using ZooResidents;

Animal Animal_1 = new Animal("Slon", "Петя", 10, "Banan", 20, "Uhu");
Animal_1.ToEat("Banan", 1);
Animal_1.ToQuantityEat();
Animal_1.ToEat("Meat", 1);
Animal_1.ToEat("Banan", 20);
Animal_1.ToQuantityEat();
Animal_1.DoVoice();
Console.WriteLine();