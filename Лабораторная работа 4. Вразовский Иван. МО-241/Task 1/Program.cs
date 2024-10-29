using System;
class Program{
    static void Main(){
        Console.WriteLine("Введите вашу последовательность");
        int n = 1;
        int n1 = 0;
        int new_num = 0;
        int count = 0;

        while(n>0){
            n = Convert.ToInt32(Console.ReadLine());
            if(n%10 == 0){
                n = n/10;
            }
            if(n<=0){
                break;
            }
            new_num = n;
            while(new_num>0){
                n1 = new_num%10;
                if(n1%2 == 0){
                    count = count + 1;
                    Console.Write(n1);
                }
                new_num = new_num/10;
            }
            if(count == 0){
                    Console.WriteLine("Чётных нет");
                
            }
            Console.WriteLine("");
            count = 0;

        }
    }
}