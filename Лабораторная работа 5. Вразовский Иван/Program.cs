using System;
using System.Collections.Concurrent;
class HelloWorld {
  static void Main() {
      //2
      Console.WriteLine("Введите числа");
      
      
      
      int[] numbers = new int[100];
      int index = 0;
      int zeroCount = 0;
      Console.WriteLine("Введите stop для остановки");
      while(true){
          string input = Console.ReadLine();
          if (input.ToLower() == "stop"){
              break;
          }
          if (int.TryParse(input, out int number)){
              numbers[index++] = number;
              if (number == 0){
                  zeroCount++;
              }
          }
          else{
              Console.WriteLine("Вводите числа, а не буквы");
          }
      }
      int resLen = index;
      int[] resNum = new int[resLen];
      for (int i = 0; i < index; i++){
        if(numbers[i] != 0){
            resNum[i] = numbers[i];
            
        }
        
      }
      
      
      
      
      int[] sortNums = GroupWithoutSorting(resNum);
      
      //1
      bool checkExOne = CheckExOne(sortNums);
      Console.WriteLine(checkExOne ? "Массив равномерно возрастающий" : "Массив не возрастающий");
      

      //3
      bool checkExTwo = CheckExTwo(sortNums);
      Console.WriteLine(checkExTwo ? "Массив содержит положительный чётный элемент на нечентом месте" : "Массив не содержит положительный чётный элемент на нечентом месте");
      
      
      
      Console.WriteLine("Итоговый массив");
      foreach(int num in sortNums){
          Console.Write(num + " ");
      }
  }



  static bool CheckExOne(int[] array){
      if (array.Length < 2){
          return true;
      }
      int n = array[1] - array[0];
      for(int i = 2; i < array.Length; i++){
          if(array[i] - array[i - 1] != n){
              return false;
          }
      }
      return true;
  }
  static bool CheckExTwo(int[] array){
    int count = 0;
      for(int i = 0; i < array.Length; i++){
          if((i + 1) % 2 != 0){
              if(array[i] > 0 && array[i] % 2 == 0){
                  count++;
                  
              }
          }
      }
      if(count > 0){
        return true;
      }
      return false;
  }

  static int[] GroupWithoutSorting(int[] arr)
{
    int n = arr.Length;
    int[] groupedArr = new int[n];

    
    int negativeCount = 0, zeroCount = 0, positiveCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] < 0) negativeCount++;
        else if (arr[i] == 0) zeroCount++;
        else positiveCount++;
    }

    
    int negIndex = 0;
    int zeroIndex = negativeCount;
    int posIndex = negativeCount + zeroCount;

    for (int i = 0; i < n; i++)
    {
        if (arr[i] < 0)
        {
            groupedArr[negIndex++] = arr[i];
        }
        else if (arr[i] == 0)
        {
            groupedArr[zeroIndex++] = arr[i];
        }
        else
        {
            groupedArr[posIndex++] = arr[i];
        }
    }

    return groupedArr;
}

}
