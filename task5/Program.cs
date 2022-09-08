// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

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

void PrintMatrixRevers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[j,i]}\t");

        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
    
}
Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(" ");

if (m == n)
{
int[,] doubleArray = new int [m,n];
FillMatrixRandom(doubleArray, 0, 10);
PrintMatrix(doubleArray);
Console.WriteLine(" ");
PrintMatrixRevers(doubleArray);
}
else Console.WriteLine("Колличество строк не совпадает с количеством столбоцов !");