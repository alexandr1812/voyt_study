﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());
int number = n;

for (int i = 2; i <= n; i+=2){
    Console.Write(i);
    Console.Write(", ");
}