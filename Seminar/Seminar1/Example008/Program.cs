// Написать программу, которая принимает на вход число и на выходе
// показывает последнюю цифру этого числа
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(n %10);
