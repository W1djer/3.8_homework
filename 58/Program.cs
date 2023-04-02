int[,] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
    Console.WriteLine();
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
int[,] Multi(int[,] matrix, int[,] array)
{
    int[,] multimatrix = new int [matrix.GetLength(0), array.GetLength(1)];
    for(int one = 0; one < matrix.GetLength(0); one++)
    {
        for(int second = 0; second < array.GetLength(1); second++)
        {
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                multimatrix[one,second] += matrix[one,i] * array[i,second];
            }
        }
    }
    return multimatrix;
}
Console.Clear();
int[,] matrix = InputMatrix();
int[,] array = InputMatrix();
if (matrix.GetLength(1) == array.GetLength(0))
{
    Console.WriteLine($"Первая матрица");
    PrintMatrix(matrix);
    Console.WriteLine($"Вторая матрица");
    PrintMatrix(array);
    Console.WriteLine($"Произведение матриц");
    PrintMatrix(Multi(matrix, array));
}
else Console.WriteLine("Нельзя умножить матрицы");