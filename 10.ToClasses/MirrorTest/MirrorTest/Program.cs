// See https://aka.ms/new-console-template for more information


int val, tmp;

Console.Write("write value : ");
val = Convert.ToInt32(Console.ReadLine());

string stringValue="";


Console.Write($"Mirror of value {val}: ");
while (val != 0)
{
    tmp = val % 10;
    val = val / 10;
    stringValue += Convert.ToString(tmp);
}
Console.WriteLine(stringValue);
