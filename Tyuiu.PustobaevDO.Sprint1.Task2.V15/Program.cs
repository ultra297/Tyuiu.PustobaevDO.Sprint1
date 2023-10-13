using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PustobaevDO.Sprint1.Task3.V15.Lib;

namespace Tyuiu.PustobaevDO.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Пустобаев Д.О. | ИСПб-23-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                          *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил Пустобаев Дмитрий Олегович | ИСПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите скорость первого автомобиля (км/ч):");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля (км/ч):");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между автомобилями (км):");
            double S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время (ч):");
            double T = Convert.ToDouble(Console.ReadLine());
 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
          

            Console.WriteLine("Расстояние между автомобилями через {0} часов: {1:F3} км", T);
        }
    }
}
