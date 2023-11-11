Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

string check = Checking(x);

Console.WriteLine(check);

string Checking(int num)
{
    string answer = "No";
    if (num % 7 == num % 23) answer = "Yes";
    return answer;
}