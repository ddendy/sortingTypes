int[] arr = {0, -5, 2, 3, 5, 9, -1, 7};
int[] res = QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Отсортированный массив: [{string.Join(",", res)}]");

int[] QuickSort(int[] inputArray, int min, int max)
{
   if(min >= max) return inputArray;
   int pivot = GetPivotIndex(inputArray, min, max);
   QuickSort(inputArray, min, pivot-1);
   QuickSort(inputArray, pivot+1, max);
   return inputArray;
}

int GetPivotIndex(int[] inputArray, int min, int max)
{
    int pivot = min - 1;
    for (int i = min; i <= max; i++)
    {
        if(inputArray[i] < inputArray[max])
        {
            pivot++;
            Swap(inputArray, ref i, ref pivot);
        }
    }
    pivot++;
    Swap(inputArray, ref pivot, ref max);
    return pivot;
}

void Swap(int[] inputArray, ref int leftValue, ref int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}