Console.Clear();

int[,] FillArray(int[,] fillArr, int min = 1, int max = 10)
{
    Random random = new Random();
    for (int i = 0; i < fillArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillArr.GetLength(1); j++)
        {
            fillArr[i, j] = random.Next(min, max);
        }
    }
    return fillArr;
}

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write("  " + arrayPrint[i, j] + "  ");
        }
        Console.WriteLine("]");
    }
}

int[,] SortArray(int[,] sortArray)
{
    int temp;
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < sortArray.GetLength(1); k++)
            {
                if (sortArray[i, j] < sortArray[i, k])
                {
                    temp = sortArray[i, j];
                    sortArray[i, j] = sortArray[i, k];
                    sortArray[i, k] = temp;
                }
            }
        }
    }
    return sortArray;
}

void MinSummElementRows(int[,] array)
{
    int summ = 0;
    int[] compare = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"сумма {i + 1} строки = {summ}");
        compare[i] = summ;
        summ = 0;
    }
    int minValue = compare[0];
    int indexMin = 1;
    for (int i = 1; i < compare.Length; i++)
    {
        if (minValue > compare[i]) { minValue = compare[i]; indexMin = i + 1; }
    }
    Console.WriteLine($"Срока массива под номером {indexMin}, имеет минимальную сумму элементов !");
}

void Zadacha1()
{
    Console.WriteLine("Задайте двумерный массив.\nНапишите программу,которая упорядочит по убыванию \nэлементы каждой строки\n");
    Console.Write("Введите количество строк массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива:");
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, colums];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine("+----------------------------+");
    SortArray(array);
    PrintArray(array);
}

void Zadacha2()
{
    System.Console.WriteLine("Задайте двумерный массив.Напишите программу,\nкоторая будет находить строку с наименьшей суммой элементов.\n");
    Console.Write("Введите количество строк массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива:");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("--------------------------");
    int[,] array = new int[rows, colums];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("--------------------------");
    MinSummElementRows(array);
    Console.WriteLine("--------------------------");

}

void Zadacha3()
{
int[,] matrix3 = new int[,]
{
    {2,4},
    {3,2}   };

int[,] matrix4 = new int[,]
{
    {3,4},
    {3,3},  };

multiplyMatrix(matrix3,matrix4);
}

void multiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)  // 2 цикла (это будут строки итоговой матрицы)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)  //2 цикла (это будут столбцы итоговой матрицы)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)  //3 цикла (для * элементов матрицы / и их сложения)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    PrintArray(resultMatrix);
}


Zadacha1();
Console.WriteLine("///////////////////////////////");
Zadacha2();
Console.WriteLine("///////////////////////////////");

// ход решения третий задачи для примера я задал матрицы сам. метод мултипли выше!
Console.WriteLine("премножение матриц: ");
int[,] matrix1 = new int[,]
{
    {1,2,2},
    {3,1,1}   };

int[,] matrix2 = new int[,]
{
    {4,2},
    {3,1},
    {1,5}   };
Console.WriteLine("---------------------");


PrintArray(matrix1);
Console.WriteLine("-----------------------");
PrintArray(matrix2);
Console.WriteLine("-----------------------");
multiplyMatrix(matrix1, matrix2);