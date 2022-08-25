// Задача 46:

/*Console.WriteLine("Колво строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колво столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] GetArray (int m, int n)
{
   int[,] matrix = new int[m, n];
   for (int i = 0; i < matrix.GetLength(0); i++)//строки
   {
    for (int j = 0; j < matrix.GetLength(1); j++)//столбцы
    {
        matrix[i, j] = new Random().Next(11);
    }
   }
   return matrix;
}
int [,] result = GetArray(rows,colums); //0 ... 10//вызов метода

void PrintArray(int [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(result);*/


/*Console.WriteLine("Колво строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колво столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, colums];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}*/


Console.WriteLine("Колво строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колво столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, colums];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        matrix[i, j] = new Random().Next(100);
        if(i % 2 == 0 && j % 2 ==  0) matrix[i, j] = Math.Pow(matrix[i, j], 2);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}


/*Console.WriteLine("Колво строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колво столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, colums];
int summ = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        matrix[i, j] = new Random().Next(10);
        if(i == j) summ += matrix[i, j];
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine(" ");
}
Console.WriteLine($"Сумма элементов главной диагонали: {summ}");*/