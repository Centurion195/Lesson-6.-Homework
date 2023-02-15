// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] CreateAndFill2Array(int rows, int columns, int lowest, int hightest){
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(lowest, hightest);
    }
    return array;
}

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Print2Array(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

int[,] ExchangeOfRows(int[,] array){
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
       temp = array[0,i];
       array[0,i] = array[array.GetLength(0)-1,i];
       array[array.GetLength(0)-1,i] = temp;
    }
    return array;
}

Console.Clear();
int rows = ReadInt("Enter the number of rows: ");
int columns = ReadInt("Enter the number of columns: ");
int lowest = ReadInt("Enter the lower bound of the random fill: ");
int hightest = ReadInt("Enter the higer bound of the random fill: ");

int[,] array = CreateAndFill2Array(rows, columns, lowest, hightest);
Print2Array(array);
Console.WriteLine();
Print2Array(ExchangeOfRows(array));