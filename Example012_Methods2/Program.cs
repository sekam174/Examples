﻿// 1. найти позицию минимального элемента
// в неотсортированной части массива
// 2. произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. повторять пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 3};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]+" "}");
    }
    Console.WriteLine();
}

PrintArray(arr);

Console.WriteLine();

void SelectionSort(int[]array)
{
    for(int i=0; i< array.Length -1; i++)
    {
        int minPosition = i;

        for( int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}
SelectionSort(arr);
PrintArray(arr);
