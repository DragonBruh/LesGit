using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine();

            Console.WriteLine("Доступные арифмит. операции.Нажми на Enter,чтобы их показать");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Сложение: +");
            Console.WriteLine("Вычитание: -");
            Console.WriteLine("Умножение: *");
            Console.WriteLine("Деление: /");


            Console.WriteLine();
            Console.Write("Выбери из четырых операций который тебе нужен: ");
            string oper = Console.ReadLine();

            if (oper == "+")
            {
                Console.Write("Сложение. Введи первую цифру: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введи вторую цифру: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a + b;
                Console.WriteLine("Вывод: " + c);
                Console.WriteLine();
            }
            else if (oper == "-")
            {
                Console.Write("Вычитание. Введи первую цифру: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введи вторую цифру: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a - b;
                Console.WriteLine("Вывод: " + c);
                Console.WriteLine();
            }
            else if (oper == "*")
            {
                Console.Write("Умножение. Введи первую цифру: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введи вторую цифру: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a * b;
                Console.WriteLine("Вывод: " + c);
                Console.WriteLine();
            }
            else if (oper == "/")
            {
                Console.Write("Деление. Введи первую цифру: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введи вторую цифру: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a / b;
                Console.WriteLine("Вывод: " + c);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вы не ввели доступные арифмитические операции. Перезапустите программу или выйдите.");
            }

            Console.WriteLine();
            Console.WriteLine("Нажми на Enter чтобы выйти");

            Console.ReadLine();
        }
    }
}
