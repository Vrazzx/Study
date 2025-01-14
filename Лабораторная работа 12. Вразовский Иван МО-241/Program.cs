

// #Лаба_за_30.12.2024
using System;
using System.Threading;
public class Oven{
    public double Temperature;
    public int CookingTime;
    public Oven(double temperature, int cookingTime){
        Temperature = temperature;
        CookingTime = cookingTime;
    }
}
public class Bread : Oven{
        public string BreadName;
        public Bread(double temperature, int cookingTime, string breadName) : base(temperature, cookingTime){
            BreadName = breadName;
        }
        public void DisplayBreadInfo(){
            System.Console.WriteLine($"Название хлеба: {BreadName}, Температура приготовления: {Temperature}, Время приготовления: {CookingTime}");
        }
}
    public class Cake : Oven{
        public string CakeName;
        public Cake(double temperature, int cookingTime, string cakeName) : base(temperature, cookingTime){
            CakeName = cakeName;
        }
        public void DisplayCakeInfo(){
            System.Console.WriteLine($"Название хлеба: {CakeName}, Температура приготовления: {Temperature}, Время приготовления: {CookingTime}");
        }
}

class Program
{
    public static Bread[] breads = new Bread[100];
    private static Cake[] cakes = new Cake[100];
    public static int countBread = 0;
    public static int countCake = 0;
    static void Main(string[] args)
    {
       int choice;
       do
       {
        
        System.Console.WriteLine("Меню: ");
        System.Console.WriteLine("1. Заполнение базы данных хлеба");
        System.Console.WriteLine("2. Заполнение базы данных тортиков");
        System.Console.WriteLine("3. Выборка по температуре");
        System.Console.WriteLine("4. Выборка по времени ");
        System.Console.WriteLine("5. Выход");
        System.Console.Write("Выберете пункт меню: ");
        
        choice = int.Parse(System.Console.ReadLine());

        switch (choice)
        {
            case 1:
                FillDatabaseBread();
                break;
            case 2:
                FillDatabaseCake();
                break;
            case 3:
                SelectByTemp();
                break;
            case 4:
                SelectByTime();
                break;
            case 5:
                System.Console.WriteLine("Выход из программы...");
                break;
            default:
                System.Console.WriteLine("Неверный выбор, попробуйтен ещё раз. ");
                break;
        }
        
       } while(choice != 5);
    
    }
    static void FillDatabaseBread()
    {
        System.Console.Write("Введите количество хлеба для добавления их в базу даных: ");
        int num = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            System.Console.Write("Введите название хлеба: ");
            string breadName = Console.ReadLine();
            System.Console.Write("Введите температуру приготовления хлеба: " );
            double temperature = double.Parse(Console.ReadLine());
            System.Console.Write("Введите время приготовления хлеба: ");
            int cookingTime = int.Parse(Console.ReadLine());
            

            breads[countBread++] = new Bread(temperature, cookingTime, breadName);
        }
        
    }
    static void FillDatabaseCake()
    {
        System.Console.Write("Введите количество тортиков для добавления их в базу даных: ");
        int num = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            System.Console.Write("Введите название Тортика: ");
            string cakeName = Console.ReadLine();
            System.Console.Write("Введите температуру приготовления тортика: " );
            double temperature = double.Parse(Console.ReadLine());
            System.Console.Write("Введите время приготовления тортика: ");
            int cookingTime = int.Parse(Console.ReadLine());
            

            cakes[countCake++] = new Cake(temperature, cookingTime, cakeName);
        }
        
    }
    static void SelectByTemp(){
        if (countBread == 0 || countCake == 0)
        {
            System.Console.WriteLine("База данных пуста. Для начала, заполните её");
            return;
        }
        System.Console.Write("Введите интересующую вас температуру: ");
        double temp = double.Parse(System.Console.ReadLine());
        for (int i = 0; i < countBread; i++)
        {
            if(breads[i].Temperature == temp)
            {
                Thread.Sleep(500);
                breads[i].DisplayBreadInfo();
            }
            
        }
        for(int i = 0; i < countCake; i++){
            if(breads[i].Temperature == temp)
            {
                Thread.Sleep(500);
                cakes[i].DisplayCakeInfo();
            }
        }
    }
    static void SelectByTime(){
        if (countBread == 0 || countCake == 0)
        {
            System.Console.WriteLine("База данных пуста. Для начала, заполните её");
            return;
        }
        System.Console.Write("Введите интересующую вас температуру: ");
        int time = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < countBread; i++)
        {
            if(breads[i].CookingTime == time)
            {
                breads[i].DisplayBreadInfo();
            }
            
        }
        for(int i = 0; i < countCake; i++){
            if(breads[i].CookingTime == time)
            {
                cakes[i].DisplayCakeInfo();
            }
        }
    }
}