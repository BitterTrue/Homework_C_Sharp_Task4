﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number:");
int N = int.Parse(Console.ReadLine());

int i=0;
while ( i <= N )
{if (i % 2 == 0)
{
  Console.WriteLine($"N= {i}");
}  
  i++;
}

