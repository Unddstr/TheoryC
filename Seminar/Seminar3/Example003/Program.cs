//Написать программу, которая на входе принимает число, а на выходе
// выдает все числа от 1 до n, возведенные в квадрат
Console.Clear();
Console.Write("Введите число: ");
int n;
int i;

n = Convert.ToInt32(Console.ReadLine());
i = 1;


while (i <= n)
{
        Console.Write($"{i*i} ");
        i++;
}