using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Введите строку с множеством пробелов");
      string input = Console.ReadLine();
      string formatted = FormattedString(input);
      int count = 0;
      int countTryWords = 0;
      int vowelCount = 0;
      int consonantCount = 0;
      Console.WriteLine(formatted);
      string[] words = Words(input);
      string vowels = "aeyuioAEYUIO";
      
      foreach(string word in words){
          foreach(char c in word){
              if(char.IsLetter(c)){
                  if(vowels.Contains(c)){
                      vowelCount++;
                  }
                  else{
                      consonantCount++;
                  }
              }
              
          }
          if(vowelCount > consonantCount){
                  countTryWords++;
              }
          vowelCount = 0;
          consonantCount = 0;
          count++;
          if(IsPalindrome(word)){
              Console.WriteLine($"Слово {word} является полиндромом");
          }
          else{
              Console.WriteLine($"Слово {word} не является полиндромом");
          }
      }
      Console.WriteLine($"Количество слов {count}");
      Console.WriteLine($"Количество слов, в которых количество согласных букв меньше чем гасных {countTryWords}");
  }
  static string FormattedString(string input){
      string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      return string.Join(" ", words);
  }
  public static string[] Words(string input){
      string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      return words;
  }
  static bool IsPalindrome(string word){
      if(string.IsNullOrEmpty(word)){
          return false;
      }
      string cleanWord = word.Replace(" ", "").ToLower();
      int length = cleanWord.Length;
      for(int i = 0; i < length / 2; i++){
          if (cleanWord[i] != cleanWord[length - 1 - i]){
              return false;
          }
      }
      return true;
  }
}