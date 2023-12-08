using System;

public class Program
{
    static void FillArray(int[] arr, int size)
    {
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void PrintArray(int[] arr, int size)
    {
        Console.Write("Array: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i],4}");
        }
        Console.WriteLine();
    }
    
    public static int FindMin(int[] arr, int size)
    {
        int minElement = arr[0];
        for (int i = 1; i < size; ++i)
        {
            if (arr[i] % 2 != 0 && arr[i] < minElement)
            {
                minElement = arr[i];
            }
        }
        return minElement;
    }

    static void FillArrayT<T>(T[] arr, int size) where T : IConvertible
    {
        for (int i = 0; i < size; i++)
        {
            arr[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
    }

    static void PrintArrayT<T>(T[] arr, int size)
    {
        Console.Write("Array: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i],4}");
        }
        Console.WriteLine();
    }
    
    public static T FindMinT<T>(T[] arr, int size) where T : IComparable<T>
    {
        T minElement = arr[0];
        for (int i = 1; i < size; ++i)
        {
            if (arr[i] is int intElement && intElement % 2 != 0 && intElement.CompareTo(minElement) < 0)
            {
                minElement = arr[i];
            }
        }
        return minElement;
    }
    
    static void Main()
    {
        int size;

        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            Console.Error.WriteLine("Invalid array size");
            Environment.Exit(1);
        }

        int[] arr = new int[size];
        FillArray(arr, size);
        PrintArray(arr, size);

        int minElement = FindMin(arr, size);
        Console.WriteLine($"Min element in array: {minElement}");

        int[] arrT = new int[size];
        FillArrayT(arrT, size);
        PrintArrayT(arrT, size);

        int minElementT = FindMinT(arrT, size);
        Console.WriteLine($"Min element in array(T): {minElementT}");
    }
}