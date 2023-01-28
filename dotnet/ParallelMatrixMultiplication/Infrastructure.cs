public static class Infrastructure
{
    public const int SIZE = 1_000;
    public const int THREADS_NUM = 10;

    public static int[,] CreateMatrix(int rows, int collumns, int minValue = -100, int maxValue = 100)
    {
        int[,] matrix = new int[rows, collumns];
        Random _rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < collumns; j++)
            {
                matrix[i, j] = _rand.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    public static void CompareMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        bool compareStatus = true;
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
            {
                if (firstMatrix[i,j] != secondMatrix[i,j])
                {
                    compareStatus = false;
                    break;
                }
            }
        }
        if (compareStatus) System.Console.WriteLine("Матрицы совпадают");
        else System.Console.WriteLine("Матрицы не совпадают");
    }
}