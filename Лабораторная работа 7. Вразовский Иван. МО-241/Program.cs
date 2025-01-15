using System;
class Program{
    static void Main(string[] args){
        System.Console.WriteLine("Введите количество строк");
        int rows = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Введите количество столбцов");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];
        bool checkChet = false;

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                System.Console.WriteLine($"Введите элемент [{i}, {j}]");
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }

        SwapMinMax(array);

        Console.WriteLine("\nВведенный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();  
        }
        
        for (int i = 0; i < rows; i++)
        {
            int sum1 = 0;
            int sumSq1 = 0;
            int zeroCount1 = 0;
            int product1 = 1;
            

            
            for (int j = 0; j < columns; j++)
            {
                sum1 += array[i, j];
                
                sumSq1 = sumSq1 + array[i, j] * array[i, j];
                if(array[i, j] == 0){
                    zeroCount1++;
                }
                product1 *= array[i, j];
            }

            
            for (int k = i + 1; k < rows; k++) 
            {
                int sum2 = 0;
                int sumSq2 = 0;
                int zeroCount2 = 0;
                int product2 = 1;

                
                for (int j = 0; j < columns; j++)
                {
                    sum2 += array[k, j];
                    
                    sumSq2 = sumSq2 + array[k, j] * array[k, j];
                    if(array[k, j] == 0){
                        zeroCount2++;
                    }
                    product2 *= array[k, j];
                }

                
                if (sum1 == sum2 && sumSq1 == sumSq2 && zeroCount1 == zeroCount2 && product1 == product2)
                {
                    Console.WriteLine($"строки {i+1}, {k+1}");
                }
                
            }
            
        }
        for (int j = 0; j < columns; j++)  
            {
                int columnSum = 0;  
                for (int i = 0; i < rows; i++) 
                {
                    columnSum += array[i, j];  
                }
                if(columnSum % 2 == 0){
                    checkChet = true;
                    
                }
                else{
                    checkChet = false;
                    break;
                }
                
            }
        if(checkChet == false){
            System.Console.WriteLine("Есть столбец, сумма элементов котрого нечетна.");
        } else{
            System.Console.WriteLine("Сумма элементов всех столбцов четна.");
        }

    static void SwapMinMax(int[,] array)
    {
        int min = array[0, 0];
        int max = array[0, 0];
        int minRow = 0, minCol = 0;
        int maxRow = 0, maxCol = 0;

        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        
        int temp = array[minRow, minCol];
        array[minRow, minCol] = array[maxRow, maxCol];
        array[maxRow, maxCol] = temp;
    }
    }
}

