using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число");
            int a = 0; int b = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            Console.WriteLine("Введите целое число");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("Введите код операции:");
            Console.WriteLine("\t 1 - сложение\n\t 2 - вычитание\n\t 3 - умножение\n\t 4 - частное");
            int c = Convert.ToInt32(Console.ReadLine());
            try
            {

                switch (c)
                {
                    case 1:
                        Console.WriteLine("Ваш выбор {0}", a + b);
                        break;
                    case 2:

                        Console.WriteLine("Ваш выбор {0}", a - b);
                        break;
                    case 3:

                        Console.WriteLine("Ваш выбор {0}", a * b);
                        break;
                    case 4:
                        c = a / b;
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка!");
            }
            if (b > 0 || b < 0)
            {
                Console.WriteLine("Ваш выбор {0}", (double)a/b);
            }
            Console.ReadKey();

            //double result1 = 0;

            //try
            //{
            //  result1 = a / b;
            //}
            //catch (DivideByZeroException)
            //   {
            //       Console.WriteLine("Ошибка");
            //   }


            //if (c == 1)
            //{
            //    double d = a + b;
            //    Console.WriteLine("Ваш выбор {0}", d);
            //}
            //else if (c == 2)
            //{
            //    double d = a - b;
            //    Console.WriteLine("Ваш выбор {0}", d);
            //}
            //else if (c == 3)
            //{
            //    double d = a * b;
            //    Console.WriteLine("Ваш выбор {0}", d);
            //}
            //else if (c == 4)
            //{

            //    try
            //    {
            //        double d = a / b;
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Ошибка");
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("Ваш выбор {0}", d);
            //}



        }
    }
}
