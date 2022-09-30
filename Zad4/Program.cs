//7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	//456 -> 6
	//782 -> 2
	//918 -> 8

Console.Write("Введите трех число ");
int a = int.Parse(Console.ReadLine());
int lastdigit = (a % 10);
Console.WriteLine(lastdigit);