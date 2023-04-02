// Сложить 2 числа с помощью рекурсии
// int f(int a, int b)
// {
//     if (a == 0)
//         return b;
//     return f(a-1, b+1);
// }

// Console.Clear();
// Console.WriteLine(f(5, 4));
/*
f(5, 4) -> f(4, 5) -> f(3, 6) -> f(2, 7) -> f(1, 8) -> f(0, 9) -> 9
*/

// Задать значение N. Написать программу, которая выведет все натуральные числа
// в промужутке от 1 до N
string f(int n)
{
    if (n == 1)
        return "1 ";
    return f(n - 1) + $"{n} ";
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));

/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/