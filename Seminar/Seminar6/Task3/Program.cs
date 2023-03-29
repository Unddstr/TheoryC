// Вывод чисел Фибоначи

int a = 0;
int b = 1;
int n = int.Parse(Console.ReadLine()!);
int c = 0;
int count = 0;
Console.Write($"{a} {b} ");
while (count < n-2)
{
   c = a + b;
   a = b;
   b = c;
   count++;
   Console.Write($"{c} ");
}

