﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите любое целое число: ");
int num = int.Parse (Console.ReadLine());

if (num % 2 == 0) Console.WriteLine ("Введенное вами число явлеяется четным.");
else Console.WriteLine ("Введенное вами число явлеяется нечетным.");