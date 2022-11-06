using ZooResidents;



Elephant Animal_1 = new Elephant("Slon", "Петя", 10, 56, new[] { "Met", "Fish", "Stuff", "Banan" });
Animal_1.ToEat();
Animal_1.ToQuantityEat();
Animal_1.DoVoice();
Animal_1.Play();
Console.WriteLine();

Elephant Animal_2 = new Elephant("Slon", "Петя", 10, -1, new[] { "Fish", "Met","Egg" });
Animal_2.ToEat();
Animal_2.ToQuantityEat();
Animal_2.DoVoice();
Animal_2.Play();
Console.WriteLine();

Elephant Animal_3 = new Elephant("Slon", "Петя", 10, 4, new[] { "Stuff", "Banan", "Met" });
Animal_3.ToEat();
Animal_3.ToQuantityEat();
Animal_3.DoVoice();
Animal_3.Play();
Console.WriteLine();

Elephant Animal_4 = new Elephant("Slon", "Петя", 10, 0, new[] { "Met", "Hay", "Egg", "Banan" });
Animal_4.ToEat();
Animal_4.ToQuantityEat();
Animal_4.DoVoice();
Animal_4.Play();
Console.WriteLine();