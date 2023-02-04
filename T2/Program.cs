// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
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

Console.WriteLine("Задайте размер массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);
double[,] Mass = new double[m, n];
CreateArray(Mass);
PrintArray(Mass);
Console.WriteLine("Укажите позицию элемента");
Console.Write("m = ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int y = int.Parse(Console.ReadLine()!);
if (x < m && y < n)
{
    Console.WriteLine($"[{m},{n}] = " + Mass[x,y]);
}
else
{
    Console.WriteLine("Нет");
}

