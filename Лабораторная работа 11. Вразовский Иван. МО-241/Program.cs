using System;
class Planet
{
    public string Name;
    public double DistanceFromCenter;
    public double Diameter;
    public int NumbersOfMoon;

    public Planet(string name, double distanceFromCenter, double diameter, int numbersOfMoon)
    {
        Name = name;
        DistanceFromCenter = distanceFromCenter;
        Diameter = diameter;
        NumbersOfMoon = numbersOfMoon;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Расстояние: {DistanceFromCenter}, Диаметер: {Diameter}, Спутники: {NumbersOfMoon}");
    }

}

class Program
{
    private static Planet[] planets = new Planet[100];
    private static int count = 0;
    static void Main(string[] args)
    {
       int choice;
       do
       {
        System.Console.WriteLine("Меню: ");
        System.Console.WriteLine("1. Заполнение базы данных");
        System.Console.WriteLine("2. Первая выборка");
        System.Console.WriteLine("3. Вторая выборка");
        System.Console.WriteLine("4. Выход");
        System.Console.Write("Выберете пункт меню: ");
        choice = int.Parse(System.Console.ReadLine());

        switch (choice)
        {
            case 1:
                FillDatabase();
                break;
            case 2:
                SelectByMoons();
                break;
            case 3:
                SelectByDistance();
                break;
            case 4:
                System.Console.WriteLine("Выход из программы...");
                break;
            default:
                System.Console.WriteLine("Неверный выбор, попробуйтен ещё раз. ");
                break;
        }
        
       } while(choice != 4);
    
    }

    static void FillDatabase()
    {
        System.Console.Write("Введите количество планет для добавления их в базу даных");
        int num = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            System.Console.Write("Введите название планеты: ");
            string name = Console.ReadLine();
            System.Console.Write("Введите удаленность планеты от центра галактики: " );
            double distance = double.Parse(Console.ReadLine());
            System.Console.Write("Введите диаметр планеты: ");
            double diameter = double.Parse(Console.ReadLine());
            System.Console.Write("Введите количество спутников: ");
            int moons = int.Parse(Console.ReadLine());

            planets[count++] = new Planet(name, distance, diameter, moons);
        }
    }
    static void SelectByMoons()
    {
        if (count == 0)
        {
            System.Console.WriteLine("База данных пуста. Для начала, заполните её");
            return;
        }
        System.Console.Write("Введите минимальное количество спутников: ");
        int minMoons = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            if(planets[i].NumbersOfMoon >= minMoons)
            {
                planets[i].DisplayInfo();
            }
        }
    }
    
    static void SelectByDistance()
    {
        if (count == 0)
        {
            System.Console.WriteLine("База данных пуста. Для начала, заполните её");
            return;
        }
        System.Console.Write("Введите минимальную удалённость: ");
        double minDistance = double.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++)
        {
            if(planets[i].DistanceFromCenter > minDistance)
            {
                planets[i].DisplayInfo();
            }
        }
    }
}