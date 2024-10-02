//3
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество Элементов");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        if (n>=3){
            Console.WriteLine("Введите Элементы");
            for (int i = 0; i<n; i++){
                int a = Convert.ToInt32(Console.ReadLine());
                if (Math.Abs(a) == 3 || Math.Abs(a % 10) == 3){
                    count += 1;
                }
                
            }
            Console.WriteLine($"количество элементов на тройку:{count}");
            
        }
    }
}
