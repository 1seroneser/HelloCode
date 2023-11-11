int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапозоне 100 - 999: {number}");

bool showSecondDigit = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа: {showSecondDigit}");

bool ShowSecondDigit(int num)
{
    return (num / 100) % 10 > 0;
}