public static class Infrastructure
{
    public static void Swap(ref int arg1, ref int arg2)
    {
        int temp = arg1;
        arg1 = arg2;
        arg2 = temp;
    }

    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max + 1))
                .ToArray();
    }

    public static void PrintArray(int[] arrayToPrint)
    {
        Console.WriteLine($"[{String.Join(',', arrayToPrint)}]");
    }
}