int[,] resultmatrix = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= resultmatrix.GetLength(0) * resultmatrix.GetLength(1))
{
  resultmatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < resultmatrix.GetLength(1) - 1) 
    j++;
  else if (i < j && i + j >= resultmatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > resultmatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(resultmatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}