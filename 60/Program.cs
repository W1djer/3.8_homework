int[,,] InputMatrix()
{
    int[,,] matrix = new int[2, 2, 3];
    Console.Write("Матрица 2х2х3");
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write($"{matrix[j, i, k]} ({j},{i},{k})\t");
            }
            Console.WriteLine();
        }
    }
}
int[,,] Sort(int[,,] matrix)
{
    int[] multimatrix = new int [matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for(int i = 0; i < multimatrix.GetLength(0); i++)
    {
        multimatrix[i] = new Random().Next(10, 100);     
    } 
    Array.Sort(multimatrix);
    int j = 0;
    for(int k = 1; k < multimatrix.GetLength(0); k++)
        {
            if (multimatrix[j] == multimatrix[k])
                {
                    multimatrix[k] = new Random().Next(multimatrix[k], 100);
                    Array.Sort(multimatrix);
                    k--;
                }
            else j++;
        }
    for (int i = multimatrix.Length - 1; i >= 1; i--)
    {
    int m = new Random().Next(i + 1);
    int temp = multimatrix[m];
    multimatrix[m] = multimatrix[i];
    multimatrix[i] = temp;
    }
    int num = 0;
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int c = 0; c < matrix.GetLength(0); c++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[c, i, k] = multimatrix[num];
                num++;
            }
        }
    }
    Console.WriteLine();
    return matrix;
}
Console.Clear();
int[,,] matrix = InputMatrix();
Sort(matrix);
PrintMatrix(matrix);