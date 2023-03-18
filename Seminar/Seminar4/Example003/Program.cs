Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
Console.WriteLine($"[{string.Join(", ", array)}]");
// Random().NextDouble() - [0, 1]
// Random().NextDouble() * (end - begin) + begin;
// end - конечное значение промежутка
// begin - начальное значение промежутка