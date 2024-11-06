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
            ////Задание 1
            //Console.WriteLine("Задание 1");
            //Console.WriteLine("e = 2,7");

            ////Задание 2
            //Console.WriteLine("Задание 2");
            //Console.WriteLine(50);
            //Console.WriteLine(10);

            ////Задание 3
            //Console.WriteLine("Задание 3");
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);



            ////Задание 4
            //Console.WriteLine("Задание 4");
            //Console.WriteLine("Введите число: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a + 10);


            ////Задание 5
            //Console.WriteLine("Задание 5");
            //int b = 10;
            //b = b * 4;
            //Console.WriteLine($"Периметр квадрата равна {b}");



            ////Задание 6
            //Console.WriteLine("Задание 6");
            //Console.WriteLine("Введите радиус окружности: ");
            //float pi = 3.14f;
            //float r = Convert.ToSingle(Console.ReadLine());
            //float length = 2 * pi * r;
            //float space = pi * r * r;
            //Console.WriteLine($"Длина окружности - {length}, площадь окружности - {space}");


            ////Задание 7
            //Console.WriteLine("Задание 7");
            //Console.WriteLine("Введите x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Math.Cos(x);
            //Console.WriteLine(y);


            ////Задание 8
            //Console.WriteLine("Задание 8");
            //Console.WriteLine("Введите длину основание a трапеции: ");
            //float osnov_a = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Введите длину основание b трапеции: ");
            //float osnov_b = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Введите высоту трапеции: ");
            //int h = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Периметр трапеции = " + h * ((osnov_a + osnov_b) / 2));

            ////Задание 9
            //Console.WriteLine("Задание 9");
            //Console.WriteLine("Стоимость 1 кг конфет - 200, печенья - 150 и яблок - 100");
            //int apple = 100;
            //int candy = 200;
            //int cake = 150;
            //Console.WriteLine("Введите кол-во конфет: ");
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кол-во печенья: ");
            //int y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите кол-во яблок: ");
            //int z1 = Convert.ToInt32(Console.ReadLine());
            //int all = x1 * candy + y1 * cake + apple * z1;
            //Console.WriteLine($"Стоимость всей покупки: {all}");









            ////Задание 10
            //Console.WriteLine("Задание 10");
            //Console.WriteLine("Мир Труд Май");
            //Console.WriteLine("Мир \n Труд \n   Май");

            ////Задание 11
            //Console.WriteLine("Задание 11");


            //Задание 12
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите фигуру: ");
            Console.WriteLine("1 - круг");
            Console.WriteLine("2 - четырехугольник");
            Console.WriteLine("3 - треугольник");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
                Console.WriteLine("Выберите , что требуется вычислить: ");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                string choose2 = Console.ReadLine();
                if (choose2 == "1")
                {
                    Console.WriteLine("Введите радиус окружности: ");
                    int RRadius = Convert.ToInt32(Console.ReadLine());
                    double answeRR3 = Math.PI * RRadius * RRadius;
                    Console.WriteLine($"Площадь круга - {answeRR3}");
                }
                else if (choose2 == "2")
                {
                    Console.WriteLine("Введите радиус окружности: ");
                    int RRadius = Convert.ToInt32(Console.ReadLine());
                    double answeRR3 = 2 * Math.PI * RRadius;
                    Console.WriteLine($"Длина круга - {answeRR3}");
                }

            }
            else if (choose == "2")
            {
                Console.WriteLine("Выберите , что требуется вычислить: ");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                string choose2 = Console.ReadLine();
                if (choose2 == "1")
                {
                    Console.WriteLine("Введите через пробел все стороны четырёхугольника: ");
                    string input = Console.ReadLine();

                    string[] nums = input.Split(' ');
                    double[] Nums2 = nums.Select(double.Parse).ToArray();
                    double poluperimetr = Nums2.Sum() / 2;
                    double answeRR3 = Math.Sqrt((poluperimetr - Nums2[0]) * (poluperimetr - Nums2[1]) * (poluperimetr - Nums2[2]) * (poluperimetr - Nums2[3]));
                    Console.WriteLine($"Площадь четырехугольника: {answeRR3}");

                }
                else if (choose2 == "2")
                {
                    Console.WriteLine("Введите через пробел все стороны четырёхугольника: ");
                    string input = Console.ReadLine();

                    string[] nums = input.Split(' ');
                    double[] Nums2 = nums.Select(double.Parse).ToArray();
                    double poluperimetr = Nums2.Sum() ;
                    Console.WriteLine($"Периметр четырёхугольника: {poluperimetr}");
                }

            }
            else if (choose == "3")
            {
                Console.WriteLine("Выберите , что требуется вычислить: ");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                string choose2 = Console.ReadLine();
                if (choose2 == "1")
                {
                    Console.WriteLine("Введите через пробел все стороны треугольника: ");
                    string input = Console.ReadLine();

                    string[] nums = input.Split(' ');
                    double[] Nums2 = nums.Select(double.Parse).ToArray();
                    double poluperimetr = Nums2.Sum() / 2;
                    double answeRR3 = Math.Sqrt((poluperimetr - Nums2[0])*(poluperimetr - Nums2[1])*(poluperimetr - Nums2[2]));
                }
                else if (choose2 == "2")
                {
                    Console.WriteLine("Введите через пробел все стороны треугольника: ");
                    string input = Console.ReadLine();

                    string[] nums = input.Split(' ');
                    double[] Nums2 = nums.Select(double.Parse).ToArray();
                    double poluperimetr = Nums2.Sum() ;
                    Console.WriteLine($"Периметр треугольника: {poluperimetr}");
                }
                else
                {
                    Console.WriteLine("Введены неправильные данные.");
                }

            }

            ////Задание 13
            //Console.WriteLine("Задание 13");
            //Console.WriteLine("Введите число: ");
            //int numbeRR = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Вы ввели число {numbeRR}");

            ////Задание 14
            //Console.WriteLine("Задание 14");
            //Console.WriteLine("2 кг\n13 17");


            ////Задание 15
            //Console.WriteLine("Задание 15");
            //Console.WriteLine("Задание 3");
            //Random random = new Random();
            //Console.WriteLine(random.Next(1, 10));
            //Console.WriteLine(random.Next(1, 10));
            //Console.WriteLine(random.Next(1, 10));
            //Console.WriteLine(random.Next(1, 10));

            ////Задание 16
            //Console.WriteLine("Задание 16");
            //int a1, b1, c1;
            //double D;
            //Console.WriteLine("Введите коэфециент a: ");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите коэфециент b: ");
            //b1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите коэфециент c: ");
            //c1 = Convert.ToInt32(Console.ReadLine());
            //D = (b1 * b1) - (4 * a1 * c1);
            //if (D == 0)
            //{
            //    int answer = (-1) * (b1) / (2 * a1);
            //    Console.WriteLine($"Корень данного уравнения: {answer}");
            //}
            //else if (D > 0)
            //{
            //    int answer1 = (int)(((-1) * b1) - Math.Sqrt(D) / (2 * a1));
            //    int answer2 = (int)((-1) * (b1) + Math.Sqrt(D) / (2 * a1));
            //    Console.WriteLine($"Корни данного уравнения:{answer1} , {answer2}. ");


            //}
            //else
            //{
            //    Console.WriteLine("Данное уравнение не имеет корней.");
            //}
            ////Задание 17
            //Console.WriteLine("Задание 17");
            //Console.WriteLine("Введите первое число: ");
            //int numberr1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число: ");
            //int numberr2 = Convert.ToInt32(Console.ReadLine());
            //float sred = (numberr1 + numberr2) / 2;
            //Console.WriteLine($"Среднее арифметическое этих чисел: {sred}");

            //double sred2 = Math.Sqrt(numberr1 * numberr2);
            //Console.WriteLine($"Среднее геометрическое этих чисел:{sred2}");


            ////Задание 18
            //Console.WriteLine("Задание 18");

            //Console.WriteLine("Введите  координаты первой точки каждую на следующей строке: ");
            //int X1 = Convert.ToInt32(Console.ReadLine());
            //int X2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите  координаты второй точки каждую на следующей строке: ");
            //int Y1 = Convert.ToInt32(Console.ReadLine());
            //int Y2 = Convert.ToInt32(Console.ReadLine());
            //double answeRR = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            //Console.WriteLine(answeRR);


            ////Задание 19
            //Console.WriteLine("Задание 19");


            ////Задание 20
            //Console.WriteLine("Задание 20");

            //Console.Write("Введите кол-во секунд: ");
            //int nRR = Convert.ToInt32(Console.ReadLine());

            //int hours = nRR / 3600;
            //int minutes = (nRR % 3600)/60;
            //int seconds = nRR % 60;
            //Console.WriteLine($"С начала суток часов прошло: {hours}");
            //Console.WriteLine($"С  начала очередного часа полных минут прошло:{minutes}");
            //Console.WriteLine($"С начала очередной минуты полных секунд прошло: {seconds}");

            ////Задание 21
            //Console.WriteLine("Задание 21");
            //int aRR = 543;
            //int bRR = 130;

            //int cRR = 130;

            //int answeRR2 = (aRR * bRR)/(cRR*cRR);

            //Console.WriteLine($"Кол-во квадратов: {answeRR2}");




            ////Задание 22
            //Console.WriteLine("Задание 22");
            //int chislo = 123;

            ////Задание 23
            //Console.WriteLine("Задание 23");

            //Console.Write("Введите число: ");
            //int numbRR = Convert.ToInt32(Console.ReadLine());
            //int sotni = numbRR / 100;
            //int tysyachi = numbRR / 1000;
            //Console.WriteLine($"Кол-во сотен: {sotni}\n Кол-во тысяч: {tysyachi}\n");


            ////Задание 24
            //Console.WriteLine("Задание 24");


            ////Задание 34
            //Console.WriteLine("Задание 34");
            //Console.WriteLine("Введите ваше имя");
            //string nameRR = Console.ReadLine();
            //Console.WriteLine(nameRR);


            //Console.WriteLine("Введите ваше имя");
            //Console.WriteLine($"Привет {nameRR}!");

            ////Задание 32
            //Console.WriteLine("Задание 32");

            //Console.WriteLine("Введите первый элемент прогрессии");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второй элемент прогрессии");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //int dRR = a2 - a1;

            //Console.WriteLine("Введите номер элемента прогрессии");
            //int nnRR = Convert.ToInt32(Console.ReadLine());

            //int answerr2 = a1 + (nnRR - 1) * dRR;
            //Console.WriteLine(answerr2);

            ////Задание 28
            //Console.WriteLine("Задание 28");
            //Console.WriteLine("Введите числа через пробел: ");
            //string input1 = Console.ReadLine();
            //string[] numbs = input1.Split(' ');
            //double[] numbs2 = numbs.Select(double.Parse).ToArray();
            //for (int i = 0; i<numbs.Length;i++)
            //{
            //    numbs2[i] = Math.Abs(numbs2[i]);
            //}
            //double mini1 = numbs2.Min();
            //double maxi1 = numbs2.Max();
            //Console.WriteLine($"Максимальное значение - {maxi1} , минимальное значение - {mini1}");
            ////Задание 29
            //Console.WriteLine("Задание 29");

            //Console.WriteLine("Введите числа через пробел: ");
            //string input = Console.ReadLine();

            //string[] nums = input.Split(' ');
            //int[] Nums2 = nums.Select(int.Parse).ToArray();

            //int mini = Nums2.Min();
            //int maxi = Nums2.Max();

            //Console.WriteLine($"Минимальное число - {mini}, максимальное число - {maxi}");
            ////Задание 30
            //Console.WriteLine("Задание 30");
            //Console.WriteLine("Введите число");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);

            //Задание 35
            Console.WriteLine("Задание 35");






        }













    }
}
