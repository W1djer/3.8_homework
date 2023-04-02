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
int Minimal(int[,] array)
{
    int sum = 0;
    int row = 1;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
           sum += array[i,j];  
        }
    int min = sum;
    sum = 0;
    for (int t = 1; t < array.GetLength(0); t++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum += array[t,j];  
        }
        if (sum < min)
        {
            min = sum;
            row = t+1;
        }
        sum = 0;
    }
    return row;
}
Console.Clear();
int[,] matrix = InputMatrix();
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    PrintMatrix(matrix);
    Console.WriteLine($"Минимальная сумма в строке: {Minimal(matrix)}");
}
else Console.WriteLine("Не прямоугольный");