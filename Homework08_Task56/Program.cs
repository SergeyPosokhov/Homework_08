//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

int RowSumElements(int[,] array, int i)
{
    int rowSum = array[i, 0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}

int minRowSum = 0;
int rowSum = RowSumElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempRowSum = RowSumElements(array, i);
    if (rowSum > tempRowSum)
    {
        rowSum = tempRowSum;
        minRowSum = i;
    }
}
Console.WriteLine($"Строкa с наименьшей суммой ({rowSum}) элементов - {minRowSum + 1} ");
