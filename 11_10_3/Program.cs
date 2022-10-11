// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Ввелите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Кол-во цифр в числе  = {GetSumNums(num)}");   


int GetSumNums(int number)
{
    int i = 0;
    while(num!=0)
    {
        num = num/10;
       
        i++;
    }
    return i;
}


//int n = 123456789; 
//int digitCount = (int)Math.Log10(n) + 1