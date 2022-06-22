// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] arr)
{
    int count = arr.Length;
    int i = 0;
    while (i < count)
    {
        arr[i] = new Random().Next (100, 999); 
        i++;
    }
    
}

void PrintArray (int[] a)
{
    int len = a.Length;
    int index = 0;
    while (index < len)
    {
        System.Console.WriteLine(a[index]);
        index++;
    }
}

int [] array = new int[5];
int length = array.Length;

int EvenCount (int [] array)
{
    int result = 0;
    for (int i=0; i<array.Length; i++)
        {
            if (array[i]%2==0) 
            result++;
        }
    return result;
}


FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в данном массиве равно: {EvenCount(array)}");