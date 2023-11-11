Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkHoliday = CheckHoliday(number);

Console.WriteLine(checkHoliday ? "Yes" : "No");

bool CheckHoliday(int num)
{
    return num == 6 || num == 7;
}