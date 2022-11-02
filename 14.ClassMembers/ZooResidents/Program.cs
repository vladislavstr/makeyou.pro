using ZooResidents;

Animals Animal_1 = new Animals();

Animal_1.Type = "Слон";
Animal_1.Name = "Петя";
Animal_1.Voice = "Ауф";
Animal_1.Ration = "Сено";
Animal_1.ToEat();
Animal_1.DoVoice();
Animal_1.Play();
Console.WriteLine();


Animals Animal_2 = new Animals();

Animal_2.Type = "Пингвин";
Animal_2.Name = "Симба";
Animal_2.Voice = "Хрю";
Animal_2.Ration = "Рыба";
Animal_2.ToEat();
Animal_2.DoVoice();
Animal_2.Play();
Console.WriteLine();


Animals Animal_3 = new Animals();

Animal_3.Type = "Тигр";
Animal_3.Name = "Матильда";
Animal_3.Voice = "Рррр";
Animal_3.Ration = "Мясо";
Animal_3.ToEat();
Animal_3.DoVoice();
Animal_3.Play();
Console.WriteLine();

