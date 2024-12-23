using System;
using System.Collections.Generic;

class PotionMaker
{
    private List<string> actions = new List<string>();

    public void ExecuteAction(string action)
    {
        string[] parts = action.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string command = parts[0];
        List<string> ingredients = new List<string>();

        // Получаем список ингредиентов
        for (int i = 1; i < parts.Length; i++)
        {
            string ingredient = parts[i];
            // Если ингредиент это результат предыдущего действия, используем его
            if (int.TryParse(ingredient, out int index) && index > 0 && index <= actions.Count)
            {
                ingredients.Add(actions[index - 1]); // -1 для индексации по 0
            }
            else
            {
                ingredients.Add(ingredient); // Сохраняем строковый ингредиент
            }
        }

        // Формируем новое слово в зависимости от команды
        string newWord = CreateWord(command, ingredients);
        actions.Add(newWord);
    }

    private string CreateWord(string command, List<string> ingredients)
    {
        string ingredientList = string.Concat(ingredients);
        switch (command)
        {
            case "MIX":
                return $"MX{ingredientList}XM";
            case "WATER":
                return $"WT{ingredientList}TW";
            case "DUST":
                return $"DT{ingredientList}TD";
            case "FIRE":
                return $"FR{ingredientList}RF";
            default:
                throw new InvalidOperationException("Unknown command");
        }
    }

    public string GetFinalResult()
    {
        if (actions.Count == 0)
            throw new InvalidOperationException("No actions performed");
        
        return actions[^1]; // Возвращаем последнее действие
    }
}

class Program
{
    static void Main(string[] args)
    {
        PotionMaker potionMaker = new PotionMaker();
        string actionFile = "D:/Users/Ivan/Desktop/Зельеварение/input10.txt";
        string[] actions = System.IO.File.ReadAllLines(actionFile);
        for(int i = 0; i < actions.Length; i++){
            potionMaker.ExecuteAction(actions[i]);
        }

        string finalSpell = potionMaker.GetFinalResult();
        Console.WriteLine($"Final spell: {finalSpell}");
    }
}
