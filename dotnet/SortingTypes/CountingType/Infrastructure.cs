public static class Infrastructure
{
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max + 1))
                .ToArray();
    }

    public static void PrintArray(int[] arrayToPrint)
    {
        System.Console.WriteLine($"[{String.Join(", ", arrayToPrint)}]");
    }

    public static int FindMaxValue(int[] inputArray)
    {
        int max = inputArray[0];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] > max) max = inputArray[i];
        }
        return max;
    }

    public static int FindMinValue(int[] inputArray)
    {
        int min = inputArray[0];
        foreach (int element in inputArray)
        {
            if (element < min) min = element;
        }
        return min;
    }

    public static int[] FrequencyDictPositiveValue(int[] inputArray)
    {
        int size = FindMaxValue(inputArray) + 1;
        int[] frequencyDict = new int[size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (inputArray[j] == i)
                {
                    frequencyDict[i]++;
                }
            }
        }
        return frequencyDict;
    }

    public static int[] FrequencyDictNegativeValue(int[] inputArray)
    {
        int maxValue = FindMaxValue(inputArray);
        int minValue = FindMinValue(inputArray);
        int size = maxValue + 1 + Math.Abs(minValue);
        int[] frequencyDict = new int[size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (inputArray[j] == i - Math.Abs(minValue))
                {
                    frequencyDict[i]++;
                }
            }
        }
        return frequencyDict;
    }

    public static int[] FrequencyDict(int[] inputArray)
    {
        int maxValue = FindMaxValue(inputArray);
        int minValue = FindMinValue(inputArray);
        if (minValue > 0) minValue = 0;
        int size = maxValue + 1 - minValue;
        int[] frequencyDict = new int[size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < inputArray.Length; j++)
            {
                if (inputArray[j] == i + minValue)
                {
                    frequencyDict[i]++;
                }
            }
        }
        return frequencyDict;
    }
}