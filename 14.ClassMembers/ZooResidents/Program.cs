using ZooResidents;

Elephant Animal_1 = new Elephant("Slon", "Петя", 10, "Hay", 56, new[] {"113","314","swg"});
Animal_1.ToEat();
Animal_1.DoVoice();
Animal_1.Play();
Console.WriteLine();

Elephant Animal_2 = new Elephant("Slon", "Петя", 10, "Hay", 1, new[] { "113", "314", "Hay" });
Animal_2.ToEat();
Animal_2.DoVoice();
Animal_2.Play();
Console.WriteLine();

Elephant Animal_3 = new Elephant("Slon", "Петя", 10, "Stuff", 10, new[] { "113", "314", "Hay" });
Animal_3.ToEat();
Animal_3.DoVoice();
Animal_3.Play();
Console.WriteLine();

//string[] RationArray = new string[] { "aaa", "fbf","Hay" };

//Elephant Animal_1 = new Elephant(RationArray);
//Animal_1.ToEat();
//Animal_1.DoVoice();
//Animal_1.Play();
//Console.WriteLine();