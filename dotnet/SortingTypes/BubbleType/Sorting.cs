using static Infrastructure;
public static class Sorting
{
    public static void BubbleSort(int[] arrayToSort)
    {
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            for (int j = 0; j < arrayToSort.Length - 1; j++)
            {
                if (arrayToSort[j] > arrayToSort[j + 1]) Swap(ref arrayToSort[j], ref arrayToSort[j + 1]);
            }
        }
    }


}