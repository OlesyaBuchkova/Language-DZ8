//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] AddArray()
{
    Console.WriteLine("задайте параметры матрицы: ");
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
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] Multiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] multi = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
            {
              for (int k = 0; k < array2.GetLength(0); k++)
                 {
                    multi[i,j] += array1[i,k] * array2[k,j];
                    
                 }
                 Console.Write(multi [i, j]  + " ");
            }
            Console.WriteLine();
    }
    return multi;
}   

int[,] array1 = AddArray();
int[,] array2 = AddArray();
Console.WriteLine();
FillArray(array1);
Console.WriteLine("---------------");
FillArray(array2);
Console.WriteLine("---------------");
Multiplication(array1, array2);