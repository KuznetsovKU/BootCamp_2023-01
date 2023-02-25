using static Infrastructure;
public static class MatrixMultiplicators
{
    public static int[,] SerialMatrixMult(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Данные матрицы нельзя перемножать!");
        int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < outputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < outputMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    outputMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return outputMatrix;
    }

    public static int[,] ParallelMatrixMult(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Данные матрицы нельзя перемножать!");
        int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        int eachThreadCalc = SIZE / THREADS_NUM;
        var threadsList = new List<Thread>();
        for (int i = 0; i < THREADS_NUM; i++)
        {
            int startThreadPosition = i * eachThreadCalc;
            int endThreadPosition = (i + 1) * eachThreadCalc;
            if (i == THREADS_NUM - 1) endThreadPosition = SIZE;
            threadsList.Add(new Thread(() => MatrixMultBody(matrix1, matrix2, startThreadPosition, endThreadPosition, outputMatrix)));
            threadsList[i].Start();
        }
        for (int i = 0; i < THREADS_NUM; i++)
        {
            threadsList[i].Join();
        }
        return outputMatrix;
    }

    public static void MatrixMultBody(int[,] matrix1, int[,] matrix2, int startThreadPosition, int endThreadPosition, int[,] multipliedMatrix)
    {
        for (int i = startThreadPosition; i < endThreadPosition; i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    multipliedMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
}