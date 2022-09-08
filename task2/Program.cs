// Дан целочисленный массив. 
// Найти среднее арифметическое каждого из столбцов.
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
FillMatrixRandom(doubleArray, 0, 30);
PrintMatrix(doubleArray);
Console.WriteLine(" ");

double sum = 0;
for (int k = 0; k < doubleArray.GetLength(1); k++)
    {
        for (int l = 0; l < doubleArray.GetLength(0); l++)
        {
            sum = sum + doubleArray[l,k];
        }
    Console.Write($"{sum/doubleArray.GetLength(0)}\t");
    sum = 0;
    }