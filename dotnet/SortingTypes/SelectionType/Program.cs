void Swap (ref int arg1, ref int arg2)
{
    int temp = arg1;
    arg1 = arg2;
    arg2 = temp;
}


void SelectionSort(int[] arrayToSort)
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

int[] testArray = {7,6,3,4,5,1,2,3};

Console.WriteLine($"[{String.Join(',', testArray)}]");
SelectionSort(testArray);
Console.WriteLine($"[{String.Join(',', testArray)}]");