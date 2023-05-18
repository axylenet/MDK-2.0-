using System;// Вариант 5(костюмы) //Гаврюшкин 21ИС-21

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в магазин мужских костюмов!");

        // список доступных костюмов с их стоимостью
        string[] suits = { "Классический костюм - 10000 руб.", "Спортивный костюм - 8000 руб.", "Праздничный костюм - 12000 руб." };

        Console.WriteLine("Выберите костюм:");
        for (int i = 0; i < suits.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {suits[i]}");
        }

        int choice = 0;
        while (choice < 1 || choice > suits.Length)
        {
            Console.Write("Введите номер выбранного костюма: ");
            choice = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Вы выбрали: {suits[choice - 1]}");
    }
}
