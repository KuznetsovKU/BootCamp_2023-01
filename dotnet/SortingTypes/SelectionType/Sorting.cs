using static Infrastructure;
public static class Sorting
{
    public static void SelectionSort(int[] arrayToSort)
    {
        int size = arrayToSort.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int position = i;
            for (int j = i + 1; j < size; j++)
            {
                if (arrayToSort[j] < arrayToSort[position]) position = j;
            }
            Swap(ref arrayToSort[i], ref arrayToSort[position]);
        }
    }
}