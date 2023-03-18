// 
Console.Clear();
int n = 0;
int result = 1;
if (n != 0 && n != 1)
{
    for (int i = 2; i <= n; i++)
    {
        result = result * i;
    }
}
Console.WriteLine(result);