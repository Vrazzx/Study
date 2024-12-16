class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine().ToUpper();

        string searchString = "XYZ";
        int count = 0;

        
        int length = input.Length;

        
        for (int i = 0; i <= length - searchString.Length; i++)
        {
            
            if (input.Substring(i, searchString.Length) == searchString)
            {
                count++;
            }
        }
        if (length == 1 && input[length - 1] == 'X')
        {
            count++;
        }
        else
        {
            if (length >= 2 && (input[length - 1] == 'X' || (input[length - 2] == 'X' && input[length - 1] == 'Y')))
            {
                count++;
            }

        }

        Console.WriteLine($"Подстрока 'XYZ' встречается {count} раз(а).");
    }
}
