using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вариант2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код операции:");
            Console.WriteLine("\t 1 - сложение\n\t 2 - вычитание\n\t 3 - умножение\n\t 4 - частное");
            try
            {
                double c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    double d = a + b;
                    Console.WriteLine("Ваш выбор {0}", d);
                }
                else if (c == 2)
                {
                    double d = a - b;
                    Console.WriteLine("Ваш выбор {0}", d);
                }
                else if (c == 3)
                {
                    double d = a * b;
                    Console.WriteLine("Ваш выбор {0}", d);
                }
               try
                {
                    if (c == 4)
                    {
                        double d = a % b;
                        Console.WriteLine("Ваш выбор {0}", d);
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка!!");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}
