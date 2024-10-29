//2
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество элементов последовательности");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        int mincount = int.MaxValue;
        
        if (n>=2){
            Console.WriteLine("Введите элемент последовательности");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b){
                count+=1;
            }
            else{
                if (count<mincount){
                    mincount = count;
                }
                count = 1;
            }

            n = n - 2;
            while (n>0){
                a = b;
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b){
                count+=1;
                }
                else{
                    if (count<mincount){
                        mincount = count;
                    }
                    count = 1;
                }
                
                n = n - 1;
                if (n == 0){
                    break;
                }
   
            }
            if (count < mincount){
                    mincount = count;
            }
            Console.WriteLine($"минимальных размер подпоследовательности, состоящий из одинаковых элементов: {mincount}");
        }
    }
}
