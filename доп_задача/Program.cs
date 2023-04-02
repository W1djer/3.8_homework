int Input()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Process(int number)
{
    int i = 1;
    int m = 1;
    while (i <= number)
    {
        m++;
        i = m*m;
    }
    return m-1;
}
Console.Clear();
Console.WriteLine($"Целая часть: {Process(Input())}");