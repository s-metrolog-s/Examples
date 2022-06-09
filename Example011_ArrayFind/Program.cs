int[] array = {15, 221, 37, 14, 25, 56, 17, 14, 18, 19};

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //выйти из цикла
    }
    index++;
}