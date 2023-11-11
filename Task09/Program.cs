int number = new Random().Next(10, 100);
// int a = number / 10;
// int b = number % 10;

Console.WriteLine($"Случайное число в диапозоне 10 - 99: {number}");

// if (a > b) Console.WriteLine($"Наибольшая цифра числа: {a}");
// else Console.WriteLine($"Наибольшая цифра числа: {b}");

// int result = a > b ? a : b;
// Console.WriteLine($"Наибольшая цифра числа: {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}