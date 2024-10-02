//1

using System;
class Program {
  static void Main() 
  {
      
      Console.WriteLine("Введите количество Элементов");
      int n = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      if (n >= 3)
      {
          Console.WriteLine("Введите Элементы");
          int a = Convert.ToInt32(Console.ReadLine());
          int b = Convert.ToInt32(Console.ReadLine());
          int c = Convert.ToInt32(Console.ReadLine());
          if (b < a && b < c)
          {
             count += 1;
          }
          n = n - 3;
          while(n > 0)
          {
              a = b;
              b = c;
              c = Convert.ToInt32(Console.ReadLine());
              if (b < a && b < c)
              {
                  count += 1;
              }
              n = n - 1;
              if (n == 0)
              {
                  break;
              }
          }
          Console.WriteLine($"Количество локальных минимумов:{count}");
          
          
      }
      else
      {
          Console.WriteLine("количество Элементов должно быть от 3 штук!!!");
      }
      
  }
}
