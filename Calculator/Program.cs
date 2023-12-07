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
                    Console.WriteLine("Введи первое число");
                    int a = Convert.ToInt32(Console.ReadLine())
            }
        }
    }
}
