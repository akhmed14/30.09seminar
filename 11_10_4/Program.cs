// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// int n = 8;
// int[] arr = new int[n];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// { 
//     arr[i] = rand.Next(0,2);
// }
// Console.WriteLine(string.Join(", ", arr)); 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        Console.Write($"{collection[index]} ");
        index++;
    }
}

int[] arr = new int[8];
FillArray(arr);



