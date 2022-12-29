void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
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

void DictionaryMatrix(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count = 1;
            if (matrix[i, j] != -100)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {  
                        if (matrix[i, j] == matrix[k, m] && (i != k || j != m))
                        {
                            matrix[k, m] = -100;
                            count++;
                        }
                        // PrintMatrix(matrix);
                        // Console.WriteLine();
                    }
                }
                Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
            }
        }
    }
    PrintMatrix(matrix);
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Конечный массив:");
DictionaryMatrix(matrix);