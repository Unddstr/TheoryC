Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число: ");
int c = int.Parse(Console.ReadLine()!);
if (a + b > c && b + c > a && a + c > b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");