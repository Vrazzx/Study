using System;
class TaskTwo{
    static void Main(){
        float a = Convert.ToInt32(Console.ReadLine());
        float b = Convert.ToInt32(Console.ReadLine());
        float mod = Math.Abs(a - b);
        float mid = (a+b)/2;
        float midmod = mod/2;
        float max = mid + midmod;
        float min = mid - midmod;
        Console.WriteLine($"max = {max}, min = {min}");

    }
}
