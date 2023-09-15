//Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[,] AddArray()
{
    Console.WriteLine("задайте параметры массива: ");
    int lengthArray = int.Parse(Console.ReadLine());
    int getArray = int.Parse(Console.ReadLine());
    int[,] array = new int[lengthArray, getArray];
    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int [,] MinElement(int [,] array)
{
    int min = array[0, 0];
    int raw = 0;
    int col = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                raw = i;
                col = j;
            }

            
        }
        
    }
    Console.WriteLine($"Минимальный элемент {min} на позиции  [{raw} и {col}");
}

int[,] Delete(int[,] array, int raw, int col)
{
    int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i - raw > 0 && j - col > 0)
            {
                newarray[i - 1, j - 1] = array[i, j];
            }
            else if (i - raw > 0 && j - col < 0)
            {
                newarray[i - 1, j] = array[i, j];
            }
            else if (i - raw < 0 && j - col > 0)
            {
                newarray[i, j - 1] = array[i, j];
            }
            else if (i - raw < 0 && j - col < 0)
            {
                newarray[i, j] = array[i, j];
            }
        }
    }
    return newarray;
}

int [,] array = AddArray();
Console.WriteLine();
FillArray(array);
MinElement(array);

Delete(array);