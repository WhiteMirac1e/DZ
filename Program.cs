﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
    if ( a > b )
        {
            if ( a > c) 
            max = a;
            else
            max = c;
        }
    else 
        {
            if ( b > c )
            max = b;
            else
            max = c;
        }
Console.WriteLine("max = " +max);