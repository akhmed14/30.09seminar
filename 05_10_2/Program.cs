//Напишите программму, которая будет принимать на вход два числа и выводить
//является ли второе число кратным первому. Если число 2 не кратно числу 1
//то программа выводит остаток от деления

Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if (a == 0) {Console.WriteLine("Error");return; }

if (a < b) {Console.WriteLine("Error");return; }

if (a%b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {a%b}");
}

