// 
Console.Clear();
int abc = new Random().Next(100, 1000);
Console.WriteLine($"Случаной сгенированное число {abc}");
int a = abc / 100;
int c = abc % 10;
int result = a*10 +c;
Console.WriteLine(result);

