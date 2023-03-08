// Напишите команду, которая на вход принимает одно число N, а на выходе
// показывает все целые числа в промежутке от -N до N
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!),
i = (-1) * n;
// Цикл for
//for (int i = (-1) * n; i <= n; i++)
 //   Console.Write($"{i} ");

//Цикл while
while  (i <= n)
{
    Console.Write($"{i} ");
    i++; 
}