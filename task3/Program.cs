// Написать программу, которая обменивает элементы первой строки и последней строки
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

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(" ");

int[,] doubleArray = new int [m,n];
FillMatrixRandom(doubleArray, -50, 30);
PrintMatrix(doubleArray);
Console.WriteLine(" ");

int k = doubleArray.GetLength(0)-1;

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            int temp = doubleArray[i,j];
            doubleArray[i,j] = doubleArray[k,j];
            doubleArray[k,j] = temp;
        }
    }
PrintMatrix(doubleArray);