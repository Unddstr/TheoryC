//Задача 4
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);
if (a * a == b || b * b == a)
    Console.Write("yes");
else
    Console.Write("no");