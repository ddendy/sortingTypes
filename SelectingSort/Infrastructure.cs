using static System.Console;
using static System.String;

public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 30)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(1, size);
        }
        return array;
    }
    public static int[] Print(this int[] array)
    {
        WriteLine($"[{Join(',', array)}]");
        return array;
    }
}

