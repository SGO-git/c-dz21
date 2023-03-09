//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int m, int n, int leftRange, int rightRange)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageRow(int[,] matrix)
{
    double sum = 0;
    double[] result = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        result[i] = Math.Round(sum/(matrix.GetLength(0)-1), 2);
        sum = 0;
    }
    return  result;
}

void PrintArr(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[,] myMatrix = CreateMatrix(4, 3, 0, 9);
PrintArray(myMatrix);
double[] avrArray = AverageRow(myMatrix);
System.Console.Write("Average rows - ");
PrintArr(avrArray);