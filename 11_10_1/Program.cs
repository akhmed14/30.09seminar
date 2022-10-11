Console.Write("Ввелите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");    
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");

int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
  
        sum = sum + number;
        number--;
    }
    return sum;
}
