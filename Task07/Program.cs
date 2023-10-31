Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0) x *= -1;
if (x >= 100 && x <= 999)
{
    Console.Write(x % 10);
}
else Console.Write("Число некорректно");