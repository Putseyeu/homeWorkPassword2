using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Хауди Хо";           
            int tryCount = 3;
            Console.WriteLine("Для доступа к секретной информации введите пароль. Подсказка:" +
                "Кто главный инфо цыган на YouTube?. У вас 3 попытки." );
            for (int i = 1; i <= tryCount; i++)
            {
                string userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Пароль введён верно. И награда для вас важная информация.\n" +
                     "Вступайте в ряды учеников школы ЯЮНИОР и это ваш путь в мир игровой индустрии");
                    break;
                }
                else
                {                    
                    if (i == tryCount)
                    {
                        Console.WriteLine("Попытки потрачены.");
                        break;
                    }
                    Console.WriteLine("Пароль не верный. попробуйте еще раз.");
                }
            }            
        }
    }
}