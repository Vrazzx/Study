using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = GetArrayFromUser(n);
        SquareArrayElements(array);
        PrintArray(array);
        
    }

    static int[] GetArrayFromUser(int n)
    {
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }
    
    static void SquareArrayElements(int[] arr){
        for(int i = 0; i < arr.Length; i++){
            arr[i] *= arr[i];
        }
    }
    
    static void PrintArray(int[] arr){
        Console.WriteLine("Введенный массив:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}