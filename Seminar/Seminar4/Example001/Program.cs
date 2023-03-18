// Сколько цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
do{
    count++;
    n /= 10;
}
while (n > 0);
Console.WriteLine(count);