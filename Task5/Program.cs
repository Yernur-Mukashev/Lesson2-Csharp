using System;
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int X = number % 10;
Console.WriteLine(X);