// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int [] sums = new int [m];
int sum = 0;
for (int k = 0; k < doubleArray.GetLength(0); k++)
    {
        for (int l = 0; l < doubleArray.GetLength(1); l++)
        {
            sum = sum + doubleArray[k,l];
           
        }
    sums[k] = sum;
    Console.WriteLine($"Сумма {k}-й строки: {sums[k]}"); 
    sum = 0;
    }

Console.WriteLine(" ");
int min = sums[0];
int count = 0;
int index = 0; 
while (count < m)
{
if (sums[count] < min) 
{
min = sums[count];
index = count;
}
count++;
}
Console.WriteLine($"Сумма {index}-й строки минимальная: {min}"); 