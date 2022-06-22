// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//было бы хорошо, если бы мы разобрали больше таких массивов на семинарах

int prompt (string message)
{
    Console.Write (message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double [] FillRealArray (int length)
{
    
    double [] RandReal = new double [length];
    for (int i =0; i<RandReal.Length;i++)
    RandReal[i]= new Random().NextDouble()*100; //как привести в порядок эти огромные числа, не нашел; не получилось отрезать цифры после нуля, некрасиво смотрится
    return RandReal;
}

void PrintArray (double[] a)
{
    int len = a.Length;
    int index = 0;
    while (index < len)
    {
        Console.WriteLine (a[index]);
        index++;
    }
}

double maxmin (double [] a)
{
    double diff=0;
    double max=a[0];
    double min=a[0];
    for (int i=0; i<a.Length; i++)
    {
        if (a[i]>max){max=a[i];}
        if (a[i]<min){min=a[i];}
    }
    diff =max-min;
    return diff;
}

int lenght = prompt ("Введите количество элементов массива ");
double [] NewArray = FillRealArray(lenght);
PrintArray(NewArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {maxmin(NewArray)}");
