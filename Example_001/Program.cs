﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int digital (int a, int b)
{
    int count = 1;
    int result = a;
    while (count < b)
    {
        result *= a;
        count += 1;
    }
    return result;
}

System.Console.WriteLine($"Результат равен {digital(a,b)}");