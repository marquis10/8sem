bool CheckNumberInArray(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
            return false;
    }
    return true;
}

int InputMatrix(int[,] matrix, int[] array)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            if(CheckNumberInArray(array, matrix[i, j]) == true)
                {
                    array[count] = matrix[i, j];
                    count++;
                }
        }
    }
    return count;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix, int[] array, int count)
{
    for (int k = 0; k < count; k++)
    {
        int countNumbers = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    countNumbers++;
            }
        }
        Console.WriteLine($"{array[k]} встречается {countNumbers} раз");
    }
}

Console.Clear();
Console.Write("Введите размер квадратного двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0] * size[1]];
Console.WriteLine("Начальный массив:");
int count = InputMatrix(matrix, array);
PrintMatrix(matrix);
ReleaseMatrix(matrix, array, count);