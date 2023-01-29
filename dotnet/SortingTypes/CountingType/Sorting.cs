using static Infrastructure;
public static class Sorting
{
    public static void CountingSortPos(int[] arrayToSort)
    {
        int index = 0;
        int[] tempArray = FrequencyDictPositiveValue(arrayToSort);
        for (int i = 0; i < tempArray.Length; i++)
        {
            for (int j = 0; j < tempArray[i]; j++)
            {
                arrayToSort[index++] = i;
            }
        }
    }
    public static void CountingSortNeg(int[] arrayToSort)
    {
        int index = 0;
        int[] tempArray = FrequencyDictNegativeValue(arrayToSort);
        for (int i = 0; i < tempArray.Length; i++)
        {
            for (int j = 0; j < tempArray[i]; j++)
            {
                arrayToSort[index++] = i - Math.Abs(FindMinValue(arrayToSort));
            }
        }
    }

    public static void CountingSort(int[] arrayToSort)
    {
        int minValue = FindMinValue(arrayToSort);
        if (minValue > 0) minValue = 0;
        int index = 0;
        int[] tempArray = FrequencyDict(arrayToSort);
        for (int i = 0; i < tempArray.Length; i++)
        {
            for (int j = 0; j < tempArray[i]; j++)
            {
                arrayToSort[index++] = i + minValue;
            }
        }
    }

}