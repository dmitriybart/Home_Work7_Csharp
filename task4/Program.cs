// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

for (int k = 0; k < doubleArray.GetLength(0); k++)
    {
        for (int l = 0; l < doubleArray.GetLength(1)-1; l++)
        {
        
        int max = doubleArray[k,l];
        
        for (int p = l+1; p < doubleArray.GetLength(1); p++)
        {
            if (doubleArray[k,p] > max) 
            {
                max = doubleArray[k,p];
                int temporary = doubleArray[k,l];
                doubleArray[k,l] = doubleArray[k,p];
                doubleArray[k,p] = temporary;
            }
        }
        }
    }
PrintMatrix(doubleArray);