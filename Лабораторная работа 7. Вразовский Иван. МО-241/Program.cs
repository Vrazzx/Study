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
                    Console.WriteLine($"Сумма столбца {j}: {columnSum}, четная");
                }
                else{
                    Console.WriteLine($"Сумма столбца {j}: {columnSum}, нечетная");
                }
                
            }
    }
}
