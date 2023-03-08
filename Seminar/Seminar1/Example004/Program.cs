//Написать программу, которая на вход принимает число, 
//а на выход выдает его квадрат
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Result: ");
Console.WriteLine(a*a);
Console.WriteLine($"Result: квадрат числа равен {a * a} ");