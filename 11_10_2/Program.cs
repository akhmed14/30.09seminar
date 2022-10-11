//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Write("Ввелите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел  = {GetMultNums(num)}");    


int GetMultNums(int number)
{
    int Mult = 1;
    while(number>0)
    {
  
        Mult = Mult * number;
        number--;
    }
    return Mult;
}
