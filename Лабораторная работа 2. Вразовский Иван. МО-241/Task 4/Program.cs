//4
using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите количество Элементов");
        int n = Convert.ToInt32(Console.ReadLine());
        bool check = true;
        if (n>=3){
            Console.WriteLine("Введите Элементы");
            for (int i = 0; i<n; i++){
                int a = Convert.ToInt32(Console.ReadLine());
                if ((Math.Abs(a) % 2 != 0) || (Math.Abs(a) % 10 != 4)){
                    check = false;
                }
                
            }
            if (check == true){
                Console.WriteLine($"Да, все элементы четны и оканчиваются на 4");
            }
            else{
                Console.WriteLine($"Нет, не все элементы чётны и оканчиваются на 4");
            }
            
        }
    }
}