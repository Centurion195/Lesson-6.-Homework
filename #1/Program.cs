// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateAndFill2Array(int rows, int columns, int lowest, int hightest){
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(random.NextDouble()*(hightest-lowest), 2);
    }
    return array;
}

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Print2Array(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = ReadInt("Enter the lower bound of the random fill: ");
int hightest = ReadInt("Enter the higer bound of the random fill: ");

double[,] array = CreateAndFill2Array(rows, columns, lowest, hightest);
Print2Array(array);