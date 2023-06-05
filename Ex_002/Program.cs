﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int summ (int n)
{
    int total = 0;
    while (n > 0)
    {
        total += n % 10;
        n = n / 10;
    }
    return total;
}

System.Console.WriteLine($"Результат равен {summ(n)}");
