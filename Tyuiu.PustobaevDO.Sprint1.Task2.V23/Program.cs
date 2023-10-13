using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PustobaevDO.Sprint1.Task2.V23.Lib;

namespace Tyuiu.PustobaevDO.Sprint1.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Пустобаев Д.О. | ИСПб-23-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил Пустобаев Дмитрий Олегович | ИСПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int munites = 2;
            int seconds = munites * 60;

            Console.WriteLine("Введите количество минут:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Время в секундах = " + seconds);

            Console.ReadLine();
        }
    }
}
