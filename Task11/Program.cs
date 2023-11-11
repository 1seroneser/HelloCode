int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число в диапозоне 100 - 999: {number}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Число без второй цифры: {removeSecondDigit}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}