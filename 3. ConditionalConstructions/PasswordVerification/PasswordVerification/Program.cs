// See https://aka.ms/new-console-template for more information

//Пользователь вводит в консоль пароль. Проверить совпадает ли он с "QWERTY123".

Console.Write("write password and press enter/return: ");

string password = Console.ReadLine();

if (password != "QWERTY123")
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine("Correct");
}