Console.Clear();

Console.Write("Введите кол-во строк созд. массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов созд. массива:");
int table = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, table, 0, 10);
PrintArray(array);
Console.WriteLine("---------------------------");

int[,] FillArray(int row, int table, int min = 1, int max = 10)
{
    Random random = new Random();
    int[,] array = new int[row, table];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write("  " + massiv[i, j] + " ");
        }
        Console.WriteLine("]");
    }
}

(int, int) SearchMin(int[,] array)
{
    int minValue = array[0, 0];
    int minIndexRow = 0;
    int minIndexCol = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                minIndexRow = i;
                minIndexCol = j;
            }
        }
    }
    return (minIndexRow, minIndexCol);
}

int[,] TransArray(int[,] array)
{
    int[,] ArrayTr = new int[rows - 1, table - 1];
    int RowCount = 0;
    int ColCount = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == SearchMin(array).Item1)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == SearchMin(array).Item2)
            {
                continue;
            }
            ArrayTr[RowCount,ColCount] = array[i,j];
            ColCount++;
        }
        RowCount++;
        ColCount = 0;

    }
    return ArrayTr;
}

PrintArray(TransArray(array));


