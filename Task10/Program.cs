int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапозоне 100 - 999: {number}");

int showSecondDigit = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа: {showSecondDigit}");

int ShowSecondDigit(int num)
{
    return (num / 10) % 10 > 0;
}