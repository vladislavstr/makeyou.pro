namespace ZooResidents.Test;
using ZooResidents;
using System;

public class AnimalsTests
{
    
    [Test]
    public void ZooResidents_WhenAIsZero_ShuldArgumtntExaption() //(int a, int b, int c, double expected)
    {

        Elephant Animal_Test = new Elephant("Efe", "Fedya", -1, -1, new[] { "113", "314", "swg" });

        //Animal_Test.ToEat();
        //Animal_Test.DoVoice();
        //Animal_Test.Play();

        Assert.Throws<ArgumentException>(() => Elephant.ToEat());
    }


}