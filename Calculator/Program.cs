using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine();

            Console.Write("Доступные арифмитические операции: ");

            while (true)
            {
                Console.WriteLine("+    -   *   /");
                Console.Write("Введи арифмитическую операцию: ");

                string operand = Console.ReadLine(); //ввод арифмитичской операции
                Console.Clear();

                try //В случаи ошибки,если вместо цифр ввести что-то иное, то программа не вылетит
                {
                    switch (operand) // + or - or / or *
                    {
                        case "+":
                            {
                                Console.Write("Введи первое число: "); //первый операнд
                                double fis = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                Console.Write("Введи второе число: "); //второй операнд
                                double tws = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine($"{fis} + {tws} = {fis + tws}");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case "-":
                            {
                                Console.Write("Введи первое число: "); //первый операнд
                                double fis = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                Console.Write("Введи второе число: "); //второй операнд
                                double tws = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine($"{fis} - {tws} = {fis - tws}");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case "*":
                            {
                                Console.Write("Введи первое число: "); //первый операнд
                                double fis = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                Console.Write("Введи второе число: "); //второй операнд
                                double tws = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();

                                Console.WriteLine($"{fis} * {tws} = {fis * tws}");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case "/":
                            {
                                Console.Write("Введи первое число: "); //первый операнд
                                double fis = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                Console.Write("Введи второе число: "); //второй операнд
                                double tws = Convert.ToDouble(Console.ReadLine());
                                Console.Clear();

                                if (tws == 0) //деление на ноль
                                {
                                    Console.WriteLine("Машина смеется над тобою,ведь на ноль делить нельзя");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine($"{fis} / {tws} = {fis / tws}");
                                    Console.ReadLine();
                                }

                                Console.Clear();
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Машина тебя не понимает.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("Машина тебя не понимает.");
                    Console.WriteLine("Ты ввел не число.");
                    Console.WriteLine(error.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}