﻿// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// Через рекурсию.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int n = 44;

void PrintBinary(int n)
{
    if (n == 0) return;
    PrintBinary(n / 2);
    Console.Write(n % 2);
}
PrintBinary(n);