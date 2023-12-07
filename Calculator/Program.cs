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

            Console.WriteLine("Какой оператор хотите использовать? ");
            Console.WriteLine("Сложение: +");
            Console.WriteLine("Вычитание: -");
            Console.WriteLine("Деление: /");
            Console.WriteLine("Умножение: *");

            

            string oper = Console.ReadLine();

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

            }
        }
    }
}
