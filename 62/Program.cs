int[] Numbers(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        array[i] = new Random().Next(10, 100);
    Console.WriteLine($"Числа [{string.Join(", ", array)}]");
    return array;
}
int[,] Fill(int[,] matrix, int[] array)
{
    int num = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[0, i] = array[num]; num++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i, 3] = array[num]; num++;
    }
    for (int i = 2; i >= 0; i--)
    {
        matrix[3, i] = array[num]; num++;
    }
    for (int i = 2; i > 0; i--)
    {
        matrix[i, 0] = array[num]; num++;
    }
    for (int i = 1; i < matrix.GetLength(1) - 1; i++)
    {
        matrix[1, i] = array[num]; num++;
    }
    for (int i = 2; i > 0; i--)
    {
        matrix[2, i] = array[num]; num++;
    }
    Console.WriteLine();
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Массив спиралью");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int[,] matrix = new int [4, 4];
int[] array = new int[16];
Numbers(array);
Fill(matrix, array);
PrintMatrix(matrix);