//Найти расстояние между двумя точками в двоичной системе координат
Console.Clear();
Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(1): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(1): ");
double y2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");