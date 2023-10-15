using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint1.Task5.V2.Lib;

namespace Tyuiu.PustobaevDO.Sprint1.Task5.V2
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил Пустобаев Дмитрий Олегович | ИСПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение температуры в градусах Фаренгейта:");
            string fahrenheitString = Console.ReadLine();

            if (double.TryParse(fahrenheitString, out double fahrenheit))

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            double celsius = (fahrenheit - 32) * 5 / 9;
            int roundedCelsius = Convert.ToInt32(celsius);

            Console.WriteLine($"Температура в градусах Цельсия: {roundedCelsius}");
        }    
    }
}




