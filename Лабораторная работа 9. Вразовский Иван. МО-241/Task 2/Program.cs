using System;
using System.Linq;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine().ToLower();
        string symbols = " ";
        int count = 1;
        int min = int.MaxValue;
        var result = "";

        int length = input.Length;
        if (length >= 3){
            for(int i = 0; i < length; i++){
                if(input[i] == 'a' && input[i+2] == 'b'){
                    char symbol = input[i+1];
                    symbols += symbol;
                }
            }
            symbols = symbols.Trim();
            string sortSymbols = SortString(symbols);
            for(int i = 0; i < sortSymbols.Length; i++){
                if (sortSymbols.Length - i == 1){
                    if(min > count){
                            min = count;
                            result = sortSymbols[i].ToString();
                        }
                    if(min == count){
                        result = result + " " + sortSymbols[i];
                    }
                }
                else{
                    if(sortSymbols[i] == sortSymbols[i+1]){
                        count++;
                    }
                    else{
                        if(min > count){
                            min = count;
                            result = sortSymbols[i].ToString();
                        }
                        if(min == count && result != sortSymbols[i].ToString()){
                            result = result + " " + sortSymbols[i];
                        }
                        count = 1;
                    
                    }

                }
            }
            System.Console.WriteLine("количество символов встречающихся миньше всего раз: " + min);
            System.Console.WriteLine("Это символы: " + result);


        }
        else{
            System.Console.WriteLine("Строка слишком короткая!");
        }

        
    }
        static string SortString(string str)
    {
        
        if (str.Length <= 1)
            return str;

        char firstChar = str[0];
        string restOfString = str.Substring(1);

        
        string sortedRest = SortString(restOfString);

       
        return InsertInSortedOrder(firstChar, sortedRest);
    }

    static string InsertInSortedOrder(char c, string sortedStr)
    {
        
        if (sortedStr.Length == 0 || c <= sortedStr[0])
            return c + sortedStr;

        
        return sortedStr[0] + InsertInSortedOrder(c, sortedStr.Substring(1));
    }
}
