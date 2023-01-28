using static Infrastructure;
using static MatrixMultiplicators;



int[,] firstMatrix = CreateMatrix(SIZE, SIZE);
int[,] secondMatrix = CreateMatrix(SIZE, SIZE);

int[,] multMatrixSerial = SerialMatrixMult(firstMatrix, secondMatrix);
int[,] multMatrixParallel = ParallelMatrixMult(firstMatrix,secondMatrix);

CompareMatrix(multMatrixSerial, multMatrixParallel);
