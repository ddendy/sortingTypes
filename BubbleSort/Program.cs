Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1,21);
}
Console.WriteLine($"Начальный массив: [{string.Join(',', array)}]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        if(array[j-1] > array[j])
        {
            int temp = array[j-1];
            array[j-1] = array[j];
            array[j] = temp;
        }
    }
}
Console.WriteLine($"Отсортированный масив: [{string.Join(',', array)}]");