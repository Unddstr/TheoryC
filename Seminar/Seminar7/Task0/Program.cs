// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// // split (" ") - создается массив строк ["3", "4"] элементы разделены пробелом
// // Select - берет какое-то значение массива например Х и делает его числом int
// // ToArray - переводит значения в массив чисел

// // Ввод нескольких чисел в одну строку
// Console.Write("Введите элементы массива")
// Console.WriteLine(size[0] + size[1] + size[2]);

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int countEven = 0;
int countOdd  = 0;
foreach (int element in array)
// цикл foreach - берет по порядку значения массива и по порядку сохраняет их
// в значение element игнорируя индексацию массива
{
    if (element % 2 == 1) // проверка является ли элемент нечетным
    {
        Console.Write($"{element} "); 
        countEven++;
    }
}
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 0) // проверка является ли элемент нечетным
    {
        Console.Write($"{element} ");
        countOdd++;
    }
}
Console.WriteLine();
if (countOdd >= countEven)
    Console.WriteLine ("Yes");
else
    Console.WriteLine ("No");