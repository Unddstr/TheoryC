// Задать массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найти сумму отрицательных и положительных элементов массива

/*процедура*/void /*которая называется*/ InputArray(int[] array) 
// принимает в себя одномерный массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // заполняем массив случайными числами
    // из промежутка [-9, 9]
}
int SumPositive(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summa += array[i];
    }
    return summa;
}
int SumNegative(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summa += array[i];
    }
    return summa;
}

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: {string.Join(", ", array)}");
Console.WriteLine($"Сумма положительных чисел равна: {SumPositive(array)}");
Console.WriteLine($"Сумма отрицательных чисел равна: {SumNegative(array)}");