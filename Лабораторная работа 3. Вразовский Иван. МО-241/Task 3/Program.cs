//3
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество элементов последовательности");
        int n = Convert.ToInt32(Console.ReadLine());

        int maxsum = int.MinValue;
        int sum = 0;
        
        if (n>=2){
            Console.WriteLine("Введите элемент последовательности");
            for(int i = 0; i<n; i++){
                int a = Convert.ToInt32(Console.ReadLine());
                
                if (a % 2 == 0){
                    sum = sum + a;
                }
                
                else{
                    if (sum > maxsum){
                        maxsum = sum;
                    }
                    sum = 0;
                }
  
            }
            if (sum > maxsum){
                maxsum = sum;
            }
            if (maxsum > int.MinValue){
                Console.WriteLine($"Максимальная сумма:{maxsum}");
            }
            else{
                Console.WriteLine($"чётные числа не обнаружены");
            }
            
        }
    }
}