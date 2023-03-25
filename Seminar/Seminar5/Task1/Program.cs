// Функции и одномерные массивы
// void f(ref int x)
// {
//     x = x + 8;
// }

// Console.Clear();
// int n = 5;
// f(ref n); // с помощью команды ref мы обращаемся к функции
// Console.WriteLine(n);

// В массивах не нужна команда "ref"
// void f(int[] i)
// {
//     i[0] += 100;
//     i[2] = i[1] + 50;
// }
// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// f(array); // применить нашу функцию к массиву array
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Напишите программу, которая выводит максмимум из 2-х чисел
int maxNumbers(int a, int b)
{
    if(a > b)
        return a; // функция return возвращает значение того типа данных
    return b;     // которое мы укажем в функции int, string, double,
}                 // массив - int[], double[]
                  // функция return завершает работу основной функции
                  // в тот момент, когда происходит возврат значения
Console.Clear();
int n = 10, m = 11;
Console.WriteLine(maxNumbers(n, m));