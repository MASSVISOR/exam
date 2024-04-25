﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите значение N:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Натуральные числа от m до n:");
        PrintNaturalNumbers(m, n);
    }

    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }
}

