using System;
public class MyClass 
{
    private int firstField;
    private int secondField;
    
    public MyClass(){
        firstField = 0;
        secondField = 0;
    }
    public MyClass(int first){
        firstField = first;
        secondField = 0;
    }
    public MyClass(int first, int second){
        firstField = first;
        secondField = second;
    }
    
    public int Sum(){
        return firstField + secondField;
    }
    public int Muplity(){
        return firstField * secondField;
    }
    public string Divide(){
        if (secondField == 0){
            return "Error";
        }
        return(firstField / secondField).ToString();
    }
    public int Subtract(){
        return firstField - secondField;
    }
    
}
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите две переменные");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        MyClass obj1 = new MyClass();
        int a = int.Parse(Console.ReadLine());
        MyClass obj2 = new MyClass(a);
        int c = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        MyClass obj3 = new MyClass(c, b);
        
        MyClass[] oblects = { obj1, obj2, obj3 };
        
        foreach (var obj in oblects)
        {
            Console.WriteLine($"Сумма: {obj.Sum()}");
            Console.WriteLine($"Произведение: {obj.Muplity()}");
            Console.WriteLine($"Деление: {obj.Divide()}");
            Console.WriteLine($"Разность: {obj.Subtract()}");
            Console.WriteLine();
        }
    }
}