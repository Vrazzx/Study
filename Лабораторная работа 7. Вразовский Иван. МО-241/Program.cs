using System;
class Program{
    static void Main(string[] args){
        System.Console.WriteLine("Введите количество строк");
        int rows = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Введите количество столбцов");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                System.Console.WriteLine($"Введите элемент [{i}, {j}]");
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nВведенный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();  // Перевод строки после вывода одной строки массива
        }
        // Проход по всем строкам и сравнение их сумм
        for (int i = 0; i < rows; i++)
        {
            int sum1 = 0;
            int sumSq1 = 0;
            int zeroCount1 = 0;
            int product1 = 1;
            

            // Суммируем элементы первой строки
            for (int j = 0; j < columns; j++)
            {
                sum1 += array[i, j];
                
                sumSq1 = sumSq1 + array[i, j] * array[i, j];
                if(array[i, j] == 0){
                    zeroCount1++;
                }
                product1 *= array[i, j];
            }

            // Сравниваем с другими строками
            for (int k = i + 1; k < rows; k++) // Сравниваем только с последующими строками
            {
                int sum2 = 0;
                int sumSq2 = 0;
                int zeroCount2 = 0;
                int product2 = 1;

                // Суммируем элементы второй строки
                for (int j = 0; j < columns; j++)
                {
                    sum2 += array[k, j];
                    
                    sumSq2 = sumSq2 + array[k, j] * array[k, j];
                    if(array[k, j] == 0){
                        zeroCount2++;
                    }
                    product2 *= array[k, j];
                }

                // Если суммы одинаковые, выводим их
                if (sum1 == sum2 && sumSq1 == sumSq2 && zeroCount1 == zeroCount2 && product1 == product2)
                {
                    Console.WriteLine($"строки {i+1}, {k+1}");
                }
                
            }
            
        }
        for (int j = 0; j < columns; j++)  // Перебор столбцов
            {
                int columnSum = 0;  // Инициализация переменной для суммы столбца

                for (int i = 0; i < rows; i++)  // Перебор строк
                {
                    columnSum += array[i, j];  // Добавление элемента столбца к сумме
                }
                if(columnSum % 2 == 0){
                    Console.WriteLine($"Сумма столбца {j}: {columnSum}, четная");
                }
                else{
                    Console.WriteLine($"Сумма столбца {j}: {columnSum}, нечетная");
                }
                
            }
    }
}
