// Задать двумерный массив следующим правилом: Aₘₙ = m+n

double[,] CreateAndFill2Array(int rows, int columns){
    double[,] array = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = i+j;  // Если используем отсчет индексов с нуля
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

double[,] array = CreateAndFill2Array(rows, columns);
Print2Array(array);