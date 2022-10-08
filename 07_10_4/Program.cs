Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count<=N)
{
    Console.Write($"{count*count} ");
    count++;
}
