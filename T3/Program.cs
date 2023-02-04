// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], -4}  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void ArithmeticMean (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        Double summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i,j];
            count++;
        }
        Console.Write($"{summ/count, -6 }");
    }
}

Console.WriteLine("Задайте размер массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
double[,] mass = new double[m, n];
CreateArray(mass);
PrintArray(mass);
ArithmeticMean(mass);