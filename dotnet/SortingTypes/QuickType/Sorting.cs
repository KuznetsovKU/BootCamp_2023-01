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
        if (j > leftSide) QuickSort(arrayToSort, leftSide, j);    // рекурсивно повторяем упражнение для левой от опорного элемента части
    }

    public static void QuickSort2(int[] arrayToSort, int leftSide, int rightSide)  // leftSide и rightSide - индексы границ массива
    {
        if (leftSide >= rightSide) return;  // задаем условие выхода из метода (границы сошлись, либо поменялись местами)
        int pivot = GetPivotIndex(arrayToSort, leftSide, rightSide);  // инициализируем опорную точку через отдельный метод
        QuickSort2(arrayToSort, leftSide, pivot - 1);   // рекурсивно запускаем метод для левой части массива
        QuickSort2(arrayToSort, pivot + 1, rightSide);  // рекурсивно запускаем метод для правой части массива
        return;
    }

    public static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex) 
    {
        int pivotIndex = minIndex - 1;  // инициализируем pivotIndex и присваиваем ему значение "-1" (да, за границами массива)
        for (int i = minIndex; i <= maxIndex; i++)  // проходим циклом по всему массиву (выборке из массива)
        {
            if (inputArray[i] < inputArray[maxIndex])  // если текущий элемент выборки меньше последнего элемента выборки
            {
                pivotIndex++;  // увеличиваем pivotIndex на 1
                Swap(ref inputArray[pivotIndex], ref inputArray[i]);  // меняем местами элемент с опорным индексом и текущий элемент выборки
            }
        }
        pivotIndex++;  // увеличиваем pivotIndex на 1
        Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]);  // меняем местами элемент с опорным индексом и последний элемент выборки
        return pivotIndex;
    }
}