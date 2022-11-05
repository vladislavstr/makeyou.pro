using ZooResidents;

Elephant Animal_1 = new Elephant("Slon","Петя", 10, "Hay",56);
Animal_1.ToEat();
Animal_1.DoVoice();
Animal_1.Play();
Console.WriteLine();

Elephant Animal_2 = new Elephant("Slon", "Петя", 10, "Hay", 0);
Animal_2.ToEat();
Animal_2.DoVoice();
Animal_2.Play();
Console.WriteLine();

Elephant Animal_3 = new Elephant("Slon", "Петя", 10, "Stuff", 10);
Animal_3.ToEat();
Animal_3.DoVoice();
Animal_3.Play();
Console.WriteLine();