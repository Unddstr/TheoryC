// Написать программу, которая будет выдавать день недели 
//по заданному числу
Console.Clear();
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine()!);
while(i<1||i>7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    i = int.Parse(Console.ReadLine()!);
}
Console.Write("Выбранный Вами день: ");
if (i == 1)
    Console.Write("Понедельник");
else if (i == 2)
    Console.Write("Вторник");
else if (i == 3)
    Console.Write("Среда");
else if (i == 4)
    Console.Write("Четверг");
else if (i == 5)
    Console.Write("Пятница");
else if (i == 6)
    Console.Write("Суббота");
else
    Console.Write("Воскресенье");