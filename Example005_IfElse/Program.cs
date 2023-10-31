Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();
if (name.ToLower() == "максим")
{
    Console.WriteLine("АААА МАКСИМ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}