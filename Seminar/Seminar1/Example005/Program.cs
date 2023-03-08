// Написать программу, которая на вход принимает два числа и проверяет
// является ли первое число квадратом второго
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);
if (a * a == b)
    Console.Write("yes");
else
    Console.Write("no");