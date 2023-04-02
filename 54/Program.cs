int[,] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
        }
        Console.WriteLine();
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        int max = array[i, j];
            for(int z = j+1; z < array.GetLength(1); z++)
            {
                if (array [i, j] < array[i, z])
                {
                    max = array [i, z];
                    array [i, z] = array [i, j];
                    array [i, j] = max;
                }
            }
        }
    }
    return array;
}
Console.Clear();
int[,] matrix = InputMatrix();
PrintMatrix(matrix);
Sort(matrix);
Console.WriteLine();
PrintMatrix(matrix);