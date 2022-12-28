void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,11);
            Console.Write($"{matrix[i,j]} \t");
        }
    Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            if (matrix[i, j] == matrix[i, j+1] || matrix[i, j] == matrix[i+1, j])
            {
                count += 1;
            }
            Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0],size[1]];
Console.WriteLine("Начальная матрица");
InputMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);