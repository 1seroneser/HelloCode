﻿Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = -x;
while (count <= x)
{
    Console.Write($"{count} ");
    count++;
}