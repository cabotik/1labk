using System;

namespace _1labk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета по двум формулам.");
            Console.WriteLine("( z1 = Sin2a + Sin5a - Sin3a)/(Cosa + 1 -2Sin3a)");
            Console.WriteLine("z2 = 2Sina");
            double z1, z2, a;
            a = CheckVariable("Введите градус угла:");
            z1 = Mathematics.Formul_1(a);
            z2 = Mathematics.Formul_2(a);
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z1 = {z2}");
        }
        private static double CheckVariable(string message) // проверяет вводимое значение
        {
            Console.WriteLine(message);
            double a;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка ввода! Попробуйте снова.");
                a = CheckVariable(message);
            }
            if (a >= 0 && a <= 360)
            {
                a *= Math.PI / 180; //проверка на диапазон чисел, если входит, то конвертация в радианы
                return a;
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Попробуйте снова!.");
                a = CheckVariable(message);
            }
            return a;
        }
    }
    /// <summary>
    /// класс для расчета формул
    /// </summary>
    public class Mathematics
    {
        public static double Formul_1(double a)// считает 1ю формулу
        {
            double result1 = 0;
            result1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
            double z1 = Math.Round(result1, 2); // округление
            return z1;
        }
        public static double Formul_2(double a)// считает 2ю формулу
        {
            double result2 = 0;
            result2 = 2 * Math.Sin(a);
            double z2 = Math.Round(result2, 2); // округление
            return z2;
        }
    }
}
