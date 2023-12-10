using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.Write("Введите номер строки: ");
        int rowPosition = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int colPosition = int.Parse(Console.ReadLine());

        string result = GetMatrixElement(matrix, rowPosition, colPosition);
        Console.WriteLine(result);
    }

    static string GetMatrixElement(int[,] matrix, int row, int col)
    {
        try
        {
            int element = matrix[row, col];
            return $"Значение элемента на позиции ({row}, {col}): {element}";
        }
        catch (IndexOutOfRangeException)
        {
            return "Такого элемента нет. Проверьте корректность указанных позиций.";
        }
    }
}
