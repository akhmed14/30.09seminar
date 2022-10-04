//Напишите программу, которая принимает на вход два числа и проверяет
//является ли одно исло квадратом другого.

Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if(a == b*b ^ b == a*a)
{
    Console.WriteLine("да");
}
else 
{
      Console.WriteLine("нет");
}

