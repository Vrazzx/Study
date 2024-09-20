using System;
class Task3{
    static void Main(){
        int l = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int per = 2*(m+l);
        int a = n*(n-1)*l;
        int f = 2*p + 2*p*(n-1) + n*per + a;
        Console.WriteLine($"f = {f}, a = {a}");
    }
}