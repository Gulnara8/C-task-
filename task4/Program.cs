﻿// Напишите программу, которая принимает на вход трехзначное число, и на выходе показывает
//  последнюю цифру этого числа:
// 456->6      
// 782->2
// 918->8

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number % 10);