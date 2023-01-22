using static Infrastructure;
using static Sorting;

int [] testArray = CreateArray(10);
PrintArray(testArray);
QuickSort(testArray, 0, testArray.Length-1);
PrintArray(testArray);