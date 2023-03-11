// Задача 3 Кратно ли число на вводе одновременно двум другим числам?
// Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a % b == 0 && a % c == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-е число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a % (b * c) == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("не кратно");