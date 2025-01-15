using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine().ToUpper(); 

        int maxLength = 0;
        int currentLength = 0;
        string sub = "XYZ"; 
        int subIndex = 0;

        foreach (char c in input)
        {
            if (c == sub[subIndex]) 
            {
                currentLength++;
                subIndex = (subIndex + 1) % sub.Length; 
            }
            else if (c == 'x') 
            {
                currentLength = 1;
                subIndex = 1; 
            }
            else
            {
                currentLength = 0; 
                subIndex = 0;
            }

            maxLength = Math.Max(maxLength, currentLength); 
        }

        Console.WriteLine($"Наибольшая длина подпоследовательности: {maxLength}");
    }
}

