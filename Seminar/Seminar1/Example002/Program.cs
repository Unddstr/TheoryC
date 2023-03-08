// найти наибольшее из 2-х чисел
// n > m
// n < m
// n = m
Console.Clear();
Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
// Можно не ставить фигурные скобки внутри операторов ветвления 
// или циклов, если внутри находится всего лишь одна строка
if (n > m) 
    Console.WriteLine(n);
else if (n < m)
    Console.WriteLine(m);
else
    Console.WriteLine("=");