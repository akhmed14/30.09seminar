//Напишите программу, которая выводит случайное трехзнаечное число и удаляет вторую цифру этого числа.


int num = new Random().Next(100,1000);
int a1 = num/100;
int a3 = num%10;
Console.WriteLine(num);
Console.WriteLine($"{a1}{a3}");
