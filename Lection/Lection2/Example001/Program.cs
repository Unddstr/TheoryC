// 
Console.Clear();
int[] array = {11, 21, 31, 41, 15, 61, 4, 17, 18, 19};

int n = array.Length; // n = длинна строки элементов массива

int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++; //index = index + 1;
}
