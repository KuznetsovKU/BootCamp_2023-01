using static Infrastructure;
public static class Sorting
{
    public static void QuickSort(int[] arrayToSort, int leftSide, int rightSide)
    {
        // вводим 2 новые переменные для сохранения исходных значений leftSide и rightSide. они потребуются в дальнейшем не измененными
        int i = leftSide;   // присваиваем переменной i актуальное значение левой границы
        int j = rightSide;  // присваиваем переменной j актуальное значение правой границы

        int pivot = arrayToSort[Random.Shared.Next(leftSide, rightSide)];  // рандомно определяем опорный элемент в массиве
        while (i <= j)  // пока границы не поменялись местами (правый левее левого и наоборот)
        {
            while (arrayToSort[i] < pivot) i++;  // пока значение слева меньше опорного элемента, двигаемся вправо, не меняя элементы местами
                                                 // находим слева от опорного элемента значение больше самого опорного элемента
            while (arrayToSort[j] > pivot) j--;  // пока значение справа меньше опорного элемента, двигаемся влево, не меняя элементы местами
                                                 // находим справа от опорного элемента значение меньше самого опорного элемента

            if (i <= j)  // если границы не поменялись местами (правый левее левого и наоборот)
            {
                Swap(ref arrayToSort[i], ref arrayToSort[j]);  // меняем местами найденные выше значения
                i++;  // продолжаем движение по массиву вправо
                j--;  // продолжаем движение по массиву влево
            }
        }
        if (i < rightSide) QuickSort(arrayToSort, i, rightSide);  // рекурсивно повторяем упражнение для правой от опорного элемента части
        if (j > leftSide) QuickSort(arrayToSort, leftSide, j);  // рекурсивно повторяем упражнение для левой от опорного элемента части
    }

    public static void QuickSort2(int[] arrayToSort, int leftSide, int rightSide)
    {
        if (leftSide >= rightSide) return;
        int pivot = GetPivotIndex(arrayToSort, leftSide, rightSide);
        QuickSort2(arrayToSort, leftSide, pivot - 1);
        QuickSort2(arrayToSort, pivot + 1, rightSide);
        return;
    }

    public static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
    {
        int pivotIndex = minIndex - 1;
        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (inputArray[i] < inputArray[maxIndex])
            {
                pivotIndex++;
                Swap(ref inputArray[pivotIndex], ref inputArray[i]);
            }
        }
        pivotIndex++;
        Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);
        return pivotIndex;
    }
}