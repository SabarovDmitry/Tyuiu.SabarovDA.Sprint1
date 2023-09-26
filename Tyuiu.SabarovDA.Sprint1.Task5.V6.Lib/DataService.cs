using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SabarovDA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int startDayOfWeek = 1;
            if (k >= 1 && k <= 365)
            {
                int dayOfWeek = (startDayOfWeek + k - 1) % 7;
                if (dayOfWeek == 0)
                    dayOfWeek = 7;
                return dayOfWeek;
            }
            else
            {
                Console.WriteLine("Неккоректное значение k. Должно быть от 1 до 365.");
                return -1;
            }

             




        }
    }
}
