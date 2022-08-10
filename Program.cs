
//Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами, округлёнными до одного знака.

    Random random = new Random(); 
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);

static void FillArray(double[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
       }
    }

}

static void PrintArray(double[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
       for(int j = 0; j < columns; j++)
       {
            Console.Write(array[i, j] + "\t");
       }
        Console.WriteLine();
    }
    Console.WriteLine();  

}  