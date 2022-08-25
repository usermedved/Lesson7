// Задача 46:

Console.WriteLine("Колво строк: ");
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
PrintArray(result);