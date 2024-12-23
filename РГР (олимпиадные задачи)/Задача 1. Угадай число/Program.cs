class Program
{
    static void Main()
    {
        Console.Write("Введите количество операций: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Введите конечный результат: ");
        long result = long.Parse(Console.ReadLine());
        long calculatedValue = result;

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            char operation = input[0];
            string value = input.Substring(2);

            if (value == "x")
            {
                // Если значение "x", нужно запомнить операцию
                if (operation == '+') calculatedValue -= 0; // x = 0 для дальнейших вычислений
                else if (operation == '-') calculatedValue += 0;
                // x = 0
            }
            else
            {
                int number = int.Parse(value);

                // Обращаем операции для выработки уравнения к X
                switch (operation)
                {
                    case '*':
                        calculatedValue /= number; // Если было умножение, делим
                        break;
                    case '-':
                        calculatedValue += number; // Если было вычитание, добавляем
                        break;
                    case '+':
                        calculatedValue -= number; // Если было сложение, вычитаем
                        break;
                }
            }
        }

        // Учитываем последний шаг, чтобы найти X
        Console.WriteLine(calculatedValue);
    }
}

