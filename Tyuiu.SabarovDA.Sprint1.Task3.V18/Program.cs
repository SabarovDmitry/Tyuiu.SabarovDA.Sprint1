using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SabarovDA.Sprint1.Task3.V18.Lib;


namespace Tyuiu.SabarovDA.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сабаров Д. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Сабаров Дмитрий Алексанрдович | ИИПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной С  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a, b, c;
            Console.WriteLine("Введите значение длины прямоугольника:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение ширины прямоугольника:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение стороны квадрата С:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Целое число будет количеством квадратов со стороной C                      ");
            Console.WriteLine("поместившихся без наложения в прямоугольник AxB  = " + ds.HowManySquares(a, b, c));
            Console.ReadKey();
        }
    }
}
