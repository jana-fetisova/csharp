﻿// Задача 8: Напишите программу, которая на вход принимает число (n), а на выходе показывает все чётные числа от 1 до n.

Console.WriteLine("Введите целое число n:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Вот все чётные числа от 1 до n:");

while(i <= n)
{
	if(i % 2 == 0)
	{
		Console.WriteLine(i);
		i = i + 1;
	}
	else 
	{
		i = i + 1;
	}
}
