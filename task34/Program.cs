// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
//  2.Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] array = CreateArrayRndInt(10, 99, 1000);
PrintArray(array);
int CounterEvenElementsArray(int[] arr)
{
  int CounterEvenElements = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (array[i] % 2 == 0) CounterEvenElements++;
  } return CounterEvenElements;
} 



int CounterEvenElements = CounterEvenElementsArray(array);
Console.WriteLine($"Количество четных чисел = {CounterEvenElements}");

