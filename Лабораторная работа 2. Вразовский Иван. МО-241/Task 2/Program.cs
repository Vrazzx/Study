//2
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество Элементов");
        int n = Convert.ToInt32(Console.ReadLine());
        int first_max = 0;
        int second_max = 0;
        
        if (n>=3){
            Console.WriteLine("Введите Элементы");
            for (int i = 0; i<n; i++){
                int a = Convert.ToInt32(Console.ReadLine());
                if (a >= first_max){
                    second_max = first_max;
                    first_max = a;
                }
                else{
                    second_max = Math.Max(a, second_max);
                }
                
            }
            Console.WriteLine($"Второй максимум:{second_max}");
            
        }
    }
}
