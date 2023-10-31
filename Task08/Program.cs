Console.Write("Введите натуральное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= x)
{
    if (count % 2 == 0) Console.Write($"{count} ");
    count++;
}