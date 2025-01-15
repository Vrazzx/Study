using System;
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
      int resLen = index + zeroCount;
      int[] resNum = new int[resLen];
      for (int i = 0; i < index; i++){
        resNum[i] = numbers[i];
      }
      for (int i = 0; i < zeroCount; i++){
        resNum[index + i] = 0;
      }
      
      int[] sortNums = SortWithoutSorting(resNum);
      
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

  static int[] SortWithoutSorting(int[] arr)
    {
        int n = arr.Length;
        int[] sortedArr = new int[n];

        
        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }

        
        int range = max - min + 1;
        int[] count = new int[range];

        
        for (int i = 0; i < n; i++)
        {
            count[arr[i] - min]++;
        }

        
        int index = 0;
        for (int i = 0; i < range; i++)
        {
            while (count[i] > 0)
            {
                sortedArr[index++] = i + min;
                count[i]--;
            }
        }

        return sortedArr;
    }
}
