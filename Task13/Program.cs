Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int showThirdDigit = ShowThirdDigit(number);

Console.WriteLine(showThirdDigit <= 9 ? showThirdDigit : "Nothing");

int ShowThirdDigit(int num)
{
    // if (num <= 99) num = 10;
    // else num = (num % 1000) / 100;
    // return num;
    return num <= 99 ? num = 10 : num = (num % 1000) / 100;
}