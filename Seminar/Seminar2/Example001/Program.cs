// 
Console.Clear();
int a = new Random().Next(10, 100);
Console.WriteLine($"Случаной сгенированное число {a}");
int b = a / 10;
int c = a % 10;
if (b > c)
Console.WriteLine(b);
else
Console.WriteLine(c);
