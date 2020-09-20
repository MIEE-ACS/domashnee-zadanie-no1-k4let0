using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол в градусах ");
            double a = double.Parse(Console.ReadLine());
            if (a < 360 && a > 0)
            {
                a = a / 180.0 * 3.14;
                Console.WriteLine($"значение угла в радианах {a:0.000}");
            }
            else
            {
                Console.WriteLine("неверное значение угла");
            }
        }
    }
}
