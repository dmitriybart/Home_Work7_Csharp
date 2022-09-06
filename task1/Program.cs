// В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, что такого элемента нет
void FillMatrixRandom (int[,] matrix, int min, int max)
{
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(min,max+1);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");

        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    
}
int[]? FindPosition(int[,] matrix, int value)
{
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value)
                return new int[]{i,j};
    return null;
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(" ");

int[,] doubleArray = new int [m,n];
FillMatrixRandom(doubleArray, -50, 30);
PrintMatrix(doubleArray);
Console.WriteLine(" ");

Console.Write("Введите искомое число: ");
int x = int.Parse(Console.ReadLine() ?? "0");

int[]? position = FindPosition(doubleArray,x);
Console.WriteLine(position==null
    ? "Числа нет в массиве!" 
    : $"Позиция элемента в массиве: ({position[0]},{position[1]})");