using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Lab_5
{
    class Program
    {
        private static double FileMassive(string point)
        {
            string readd = File.ReadAllText(point);
            double x = Convert.ToDouble(readd);

            try
            {
                //double x = Convert.ToDouble(readd);
                x = Convert.ToDouble(readd);
            }

            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            return x;
        }
        private static int choice1(int num)
        {
            if (num == 1)
            {
                string x = @"C:\Users\пк\Desktop\Lab_4\x.txt";
                string y = @"C:\Users\пк\Desktop\Lab_4\y.txt";
                double x1 = FileMassive(x);
                double y1 = FileMassive(y);
                Console.WriteLine("Координати точки з файлу: ");
                Console.WriteLine("(" + x1 + ", " +  y1 + ")");               
            }
            else if (num == 2)
            {
                Console.WriteLine("Вкажіть координату x Вашої початкової точки: ");
                string input1;
                input1 = Console.ReadLine();
                double x = Convert.ToDouble(input1);
                Console.WriteLine("Вкажіть координату y Вашої початкової точки: ");
                string input2;
                input2 = Console.ReadLine();
                double y = Convert.ToDouble(input2);

                Console.WriteLine("Координати заданої точки: (" + x + ", " + y + ")");
            }
            else
            {
                Console.WriteLine("Введіть цифру або 1, або 2!");
            }
            return (num);
        }

        private static double distance(double pointx, double pointx1, double pointy, double pointy1)
        {
            double dist;
            dist = ((pointx1 - pointx) * (pointx1 - pointx)) + ((pointy1 - pointy) * (pointy1 - pointy));
            double kvadr;
            kvadr = Math.Pow(dist, 0.5);

            Console.WriteLine("Відстань від заданої точки до точки: " + kvadr);
            return kvadr;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Як ви хочете задати дані масиву? \n1 - з файлу; \n2 - писати вручну; \nВаша цифра:");
            string input;
            input = Console.ReadLine();
            int digit1 = Convert.ToInt32(input);
            choice1(digit1);

            Console.WriteLine("Введіть координати точки, до якої хочете знайти відстань: ");
            Console.WriteLine("Точка х: ");
            string stringx;
            stringx = Console.ReadLine();
            double pointx = Convert.ToDouble(stringx);

            Console.WriteLine("Точка y: ");
            string stringy;
            stringy = Console.ReadLine();
            double pointy = Convert.ToDouble(stringy);

            Console.WriteLine("Координати другої точки: (" + pointx + ", " + pointy + ")");

            distance(choice1, pointx, pointy);
      

            Console.ReadKey();
        }
    }
}
