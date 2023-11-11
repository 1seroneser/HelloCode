Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());

bool result = CheckSquareTwoNumbers(x, y);

Console.WriteLine(result ? "Yes" : "No");

bool CheckSquareTwoNumbers(int firstNum, int secondNum)
{
    return firstNum * firstNum == secondNum || secondNum * secondNum == firstNum;
}