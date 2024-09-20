using System;
class Program{
    static void Main(){
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int t = a*b;
        int a1 = t/a;
        int b1 = t/b;
        Console.WriteLine($"a = {a1}, b = {b1}");
    }
}