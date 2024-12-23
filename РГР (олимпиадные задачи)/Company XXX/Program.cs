using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var relationships = new Dictionary<string, List<string>>();
        var names = new Dictionary<string, string>();
        string file = "D:/Users/Ivan/Desktop/Компания ХХХ/input_s1_10.txt";
        string[] filePath = File.ReadAllLines(file);
        

        // Чтение первой части: построение графа отношений
        for(int i = 0; i < filePath.Length - 2; i+=2){

            var boss = filePath[i];
            var subordinate = filePath[i+1];

            var bossId = boss.Substring(0, 4);
            var subordinateId = subordinate.Substring(0, 4);

            if (!relationships.ContainsKey(bossId))
            {
                relationships[bossId] = new List<string>();
            }

            relationships[bossId].Add(subordinateId);
            // Обработка имени для boss
            if (!names.ContainsKey(bossId) || names[bossId] == "Unknown Name")
            {
                names[bossId] = boss.Length > 5 ? boss.Substring(5).Trim() : "Unknown Name";
            }

            // Обработка имени для subordinate
            if (!names.ContainsKey(subordinateId) || names[subordinateId] == "Unknown Name")
            {
                names[subordinateId] = subordinate.Length > 5 ? subordinate.Substring(5).Trim() : "Unknown Name";
            }
        }
        
        
       
    
        // Чтение второго блока: запрос на поиск подчиненных
        var input = filePath[filePath.Length - 1];
        var searchId = input.Length == 4 ? input : names.Keys.FirstOrDefault(id => names[id] == input);

        // Нахождение всех подчиненных
        var allSubordinates = new HashSet<string>();
        FindSubordinates(searchId, relationships, allSubordinates);

        // Вывод результата
        if (allSubordinates.Count == 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            foreach (var subordinateId in allSubordinates.OrderBy(id => id))
            {
                Console.WriteLine($"{subordinateId} {names[subordinateId]}");
            }
        }
    }

    static void FindSubordinates(string bossId, Dictionary<string, List<string>> relationships, HashSet<string> allSubordinates)
    {
        if (!relationships.ContainsKey(bossId)) return;

        foreach (var subordinateId in relationships[bossId])
        {
            if (!allSubordinates.Contains(subordinateId))
            {
                allSubordinates.Add(subordinateId);
                FindSubordinates(subordinateId, relationships, allSubordinates);
            }
        }
    }
}
