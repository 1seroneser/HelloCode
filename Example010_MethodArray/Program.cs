int[] array = {312, 123, 21, 342, 4536, 4256, 4526, 645, 67, 23, 342, 67, 45, 234};

int n = array.Length;
int find = 4526;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}