namespace ZooResidents.Test;
using ZooResidents;
using System;

public class AnimalsTests
{
    
    [Test]
    public void ZooResidents_WhenAIsZero_ShuldArgumtntExaption() //(int a, int b, int c, double expected)
    {

        string type="Elephant";
        string name= "Vasya";
        int age= -1;
        string ration= "wfdf";
        int rationMass = -1;
        string[] array = new string[] { "sfds", "sf" };

        Assert.Throws<ArgumentException>(() => Elephant( type,  name,  age,  ration,  rationMass,  array));
    }


}