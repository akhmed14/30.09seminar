﻿//Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите x1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите y2 ");
int y2 = int.Parse(Console.ReadLine());


double Distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));


Console.WriteLine($"Расстояние от точки А до точки В равно {Distance}");