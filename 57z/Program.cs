void InputMatrix(int[,] matrix, int[] temp)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,11);
            Console.Write($"{matrix[i,j]} \t");
            temp[count] = matrix[i, j];
            count++;
        }
    Console.WriteLine();
    }
}

void ReleaseMatrix(int[] temp)
{
    for (int i = 0; i < temp.Length; i++)
    {
        int count = 0;
        int c = 0;
        for (int j = 0; j < temp.Length; j++)
        {
            if (temp[i] == temp[j])
                count++;
        }
        for (int a = 0; a < i; a++)
        {
            if (temp[i] == temp[a])
                c++;
        }
        if (c == 0)
            Console.WriteLine($"число {temp[i]} встречается {count} раз");
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] temp = new int[size[0] * size[1]];
Console.WriteLine("Начальная матрица");
InputMatrix(matrix, temp);
Console.WriteLine();
Console.WriteLine($"Временный массив: [{string.Join(", ", temp)}]");
ReleaseMatrix(temp);