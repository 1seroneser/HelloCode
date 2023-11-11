Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());

int remainds = Remainder(x, y);

// if (remainds == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток {remainds}");

Console.WriteLine(remainds == 0 ? "Кратно" : $"Не кратно, остаток {remainds}");

int Remainder (int first, int second)
{
    return first % second;
}