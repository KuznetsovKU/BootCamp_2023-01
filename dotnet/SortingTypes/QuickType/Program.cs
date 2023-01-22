using static Infrastructure;
using static Sorting;

int[] testArray = CreateArray(10);
PrintArray(testArray);
QuickSort(testArray, 0, testArray.Length - 1);
PrintArray(testArray);

int[] testArray2 = CreateArray(10);
PrintArray(testArray2);
QuickSort2(testArray2, 0, testArray2.Length - 1);
PrintArray(testArray2);