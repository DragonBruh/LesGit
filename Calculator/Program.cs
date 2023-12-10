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
            Console.WriteLine("The is calculator");


            Console.Write("Нажми на Enter, чтобы показать доступные арифмитические операции.");
            Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("Сложение: +");
            Console.WriteLine("Вычитание: -");
            Console.WriteLine("Деление: /");
            Console.WriteLine("Умножение: *");

            Console.WriteLine();
            Console.WriteLine("Нажми на Enter,чтобы продолжить");
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Какую арифмитичсекую операцию хотите использовать? ");



            
            string oper = Console.ReadLine();
            Console.WriteLine();

            switch (oper)
            {
                case "+":
                    {
                        Console.Write("Сложение. Введи первое число: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введи второе число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = a + b;
                        Console.WriteLine("Вывод: " + c);


                    }
                    break;


                case "-":
                    {
                        Console.Write("Вычитание. Введи первое число: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введи второе число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = a - b;
                        Console.WriteLine("Вывод: " + c);
                    }
                    break;


                case "*":
                    {
                        Console.Write("Умножение. Введи первое число: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введи второе число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = a * b;
                        Console.WriteLine("Вывод: " + c);
                    }
                    break;


                case "/":
                    {
                        Console.Write("Деление. Введи первое число: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введи второе число: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = a / b;
                        Console.WriteLine("Вывод: " + c);
                    }
                    break;


                default:
                    {
                        Console.WriteLine("Ты не ввел один оператор из четырёх оператора,перезапусти");
                    }
                    break;

            }

            Console.WriteLine("Нажми на Enter что-бы выйти");
            Console.ReadLine();

        }
    }
}
