﻿/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/
Console.Clear();
//Вводим число
Console.WriteLine("Введите число:");
String input = Console.ReadLine();
int num1 = int.Parse(input);
 for (int i = 0; i <= num1; i++)
    {
    if (i%2 == 0)
        {
    Console.Write(i + " ");
        } 
    }
    Console.WriteLine(" ");
