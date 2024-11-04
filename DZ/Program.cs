using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ALMAZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа. Задание 2.1.
            Console.WriteLine("лабораторная 1");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет , {name}!");
            //Лабораторная работа. Задание 2.2.
            Console.WriteLine("лабораторная 2");
            Console.WriteLine("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                var answer = number1 / number2;
                Console.WriteLine($"Результат деления: {answer}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: деление на 0");
            }

            //Домашняя работа. Задание 2.1.
            Console.WriteLine("Домашняя 1");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine((char)(letter + 1));
            //Домашняя работа. Задание 2.2.
            Console.WriteLine("Домащняя 2");
            int a, b, c;
            double D;
            Console.WriteLine("Введите коэфециент a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэфециент b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэфециент c: ");
            c = Convert.ToInt32(Console.ReadLine());
            D = (b * b) - (4 * a * c);
            if (D == 0)
            {
                int answer = (-1) * (b) / (2 * a);
                Console.WriteLine($"Корень данного уравнения: {answer}");
            }
            else if (D > 0)
            {
                int answer1 = (int)(((-1) * b) - Math.Sqrt(D) / (2 * a));
                int answer2 = (int)((-1) * (b) + Math.Sqrt(D) / (2 * a));
                Console.WriteLine($"Корни данного уравнения:{answer1} , {answer2}. ");


            }
            else
            {
                Console.WriteLine("Данное уравнение не имеет корней.");
            }


        }













    }
}
