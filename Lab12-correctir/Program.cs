using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_correctir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус окружности ");
            Krug.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату х:  ");
            Krug.X= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y:  ");
            Krug.Y= Convert.ToInt32(Console.ReadLine());
            Krug.Koordinaty();
            Krug.SS();
            Krug.Duga();
            Krug.Result();
            Console.ReadKey();
        }
    }
    static class Krug
    {
        public static double Radius { get; set; }
        static double S;
        static double L;
        public static int X { get; set; }
        public static int Y { get; set; }
        public static void Koordinaty()
        {
            if (Math.Pow(Y, 2) + Math.Pow(X, 2) <= Math.Pow(Radius, 2))
                Console.WriteLine("Точка пренадлежит окружности ");
            else
                Console.WriteLine("Точка не пренадлежит окружности ");
        }
        
        public static void SS()
        {
            S = (2 * Math.PI * Math.Pow(Radius, 2));
        }
        public static void Duga()
        {
            L = (2 * Math.PI * Radius);
        }

        public static void Result()
        {
            Console.WriteLine("Площадь окружности: {0}", S);
            Console.WriteLine("Длина окружности: {0}", L);

        }
    }
}
