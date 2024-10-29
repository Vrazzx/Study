//1
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество элементов последовательности");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int maxcount = 0;
        
        if (n >= 2){
            Console.WriteLine("Введите элемент последовательности");
            for (int i = 0; i<n; i++){
                
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 0){
                    count+=1;
                    maxcount = count;
                }
                else{
                    count = 0;
                }
                
            }
            Console.WriteLine($"Максимальная длина подпоследовательности из ненулевых элементов:{maxcount}");
        }
    }
}
