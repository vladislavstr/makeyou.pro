// See https://aka.ms/new-console-template for more information

//Пользователь вводит пароль до тех пор, пока введенное значение не будет равно "Pass123!"

Console.Write("write password and press enter/return: ");

string password = Console.ReadLine();
string truePassword = "Pass123!";

do
{
    Console.WriteLine("Error");
    password = Console.ReadLine();
}
while (password != truePassword);

Console.WriteLine("Correct");