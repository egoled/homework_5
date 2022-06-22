// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int [] RandArray(int whole, int min, int max)
{
    int [] ArrayNew = new int[whole];
    for (int i =0; i<ArrayNew.Length;i++)
    {
    ArrayNew[i]= new Random().Next(min,max+1);
    }
    return ArrayNew;
    
}

void PrintArray (int[] a)
{
    int len = a.Length;
    int index = 0;
    while (index < len)
    {
        Console.WriteLine (a[index]);
        index++;
    }
}

int OddIndCount (int[] a)
{
    int result = 0;
    int i = 0;
    for (i = 0; i < a.Length; i = i + 2)
    result = result + a[i];
    return result;   
}


int min = prompt("Введите минимальное число массива: ");
int max = prompt("Введите максимальное число массива: ");
int whole = prompt ("Введите количество элементов массива: ");
int [] NewArray = RandArray(whole, min, max);
PrintArray (NewArray);
System.Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {OddIndCount(NewArray)}");