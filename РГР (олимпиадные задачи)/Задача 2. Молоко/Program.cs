using System;
using System.IO;
class HelloWorld
{
    static void Main()
    {
        double minCost = double.MaxValue;
        int bestCompany = 0;
        int count = 0;
        string filePath = "C:/temp/Упаковки молока/input1.txt"; //Сюда необходимо вписапть название файла
        try{
            string[] lines = File.ReadAllLines(filePath);
            int n = int.Parse(lines[0]);
            for (int l = 1; l < lines.Length; l++){
                count++;
                for (int i = 0; i < n; i++)
                {
                    
                    string input = lines[l];
                    string[] elements = input.Split(' ');

                    //if

                    int[] sizes = new int[6];
                    double[] costs = new double[2];
                    for (int j = 0; j < 6; j++)
                    {
                        sizes[j] = int.Parse(elements[j]);
                    }
                    for (int k = 0; k < 2; k++)
                    {
                        costs[k] = double.Parse(elements[6 + k]);
                    }

                    var (v1, v2) = FindVolume(sizes);
                    var (s1, s2) = FindSquare(sizes);

                    double determinant = s1 * v2 - s2 * v1;
                    if (determinant == 0)
                    {
                        Console.WriteLine("СЛУ неопределенная");
                    }
                    else
                    {
                        double x = (costs[0] * v2 - costs[1] * v1) / determinant; //x - цена за 1 см2
                        double y = (costs[1] * s1 - costs[0] * s2) / determinant; //y - цена за 1 литр
                        if (y < minCost)
                        {
                            minCost = y;
                            bestCompany = count;
                        }
                    }



                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        
        
        minCost = Math.Round(minCost, 2);
        Console.WriteLine($"{bestCompany}, {minCost}");
    }
    public static (double, double) FindVolume(int[] arr)
    {
        double V1 = (arr[0] * arr[1] * arr[2]);
        double V2 = (arr[3] * arr[4] * arr[5]);
        V1 = V1 / 1000;
        V2 = V2 / 1000;
        return (V1, V2);
    }
    public static (double, double) FindSquare(int[] arr)
    {
        double S1 = ((2 * ((arr[0] * arr[1]) + (arr[1] * arr[2]) + (arr[0] * arr[2]))));
        double S2 = ((2 * ((arr[3] * arr[4]) + (arr[4] * arr[5]) + (arr[3] * arr[5]))));
        return (S1, S2);
    }
}



//MILK 50p = x + y  75p
//S = 2(ab + bc + ac) - формула площади поверхности паралелепипида
// V = abc
// cost = s*x + v*y где х это цена за 1 см2 а н цена за 1 литр молока

