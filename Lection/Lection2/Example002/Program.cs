//Поиск на какой позиции находится элемент в массиве
void FillArray(int[] collection) 
//void - это метод, который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); 
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если искомого элемента нет, будет "-1"(общепринято)
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать массив с 10-ю элементами, 
                            //по умолчанию массив наполнен нулями
FillArray(array);          // эта функция заполняет массив элементами
array[4] = 8;
array[6] = 8;
PrintArray(array);         // эта функция распечатывает массив
Console.WriteLine();

int pos = indexOf(array, 15); // здесь вводим искомый элемент массива
Console.WriteLine(pos);