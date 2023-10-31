Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y) Console.Write($"min - {y}, max - {x} ");
else Console.Write($"min - {x}, max - {y} ");