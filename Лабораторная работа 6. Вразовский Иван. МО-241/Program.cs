

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество массивов");
        int n = int.Parse(Console.ReadLine());
        // int count = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        bool checkMax = false;
        bool checkMin = false;
        int[][] stepArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите элементы подмассива через пробел");
            string input = Console.ReadLine();
            string[] stringNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            stepArray[i] = new int[stringNumbers.Length];
            for (int j = 0; j < stringNumbers.Length; j++)
            {
                stepArray[i][j] = int.Parse(stringNumbers[j]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < stepArray[i].Length; j++)
            {

                if (j == 0 && i != 0)
                {
                    if (checkMax == true && checkMin == true)
                    {
                        Console.WriteLine($"Строка, содержащая четный максимальный и минимальный элемент имеет номер {i}. Максимум {max} Минимум {min}");
                    }
                    else{
                        Console.WriteLine($"Строка {i} не содержит четные и максимум и минимум. Максимум {max} Минимум {min}");
                    }
                    max = int.MinValue;
                    min = int.MaxValue;
                }
                if (stepArray[i][j] > max)
                {
                    max = stepArray[i][j];
                    if (stepArray[i][j] % 2 == 0)
                    {
                        checkMax = true;
                    }
                    else
                    {
                        checkMax = false;
                    }

                }
                if (stepArray[i][j] < min)
                {
                    min = stepArray[i][j];
                    if (stepArray[i][j] % 2 == 0)
                    {
                        checkMin = true;

                    }
                    else
                    {
                        checkMin = false;
                    }

                }

            }
        }
        if (checkMax == true && checkMin == true)
        {
            Console.WriteLine($"Строка, содержащая четный максимальный и минимальный элемент имеет номер {n}. Максимум {max} Минимум {min}");
        }
        else{
            Console.WriteLine($"Строка {n} не содержит четные и максимум и минимум. Максимум {max} Минимум {min}");
        }


    }
}
