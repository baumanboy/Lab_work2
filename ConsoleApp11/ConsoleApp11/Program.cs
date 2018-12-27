﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _laba
{
    /// <summary>
    /// Figure.
    /// </summary>
    abstract class Figure
    {

        public string Type
        { get; set; }
        public abstract double Area();

        public override string ToString()
        {
            return this.Type + "площадь " + this.Area().ToString();
        }
    }
    /// <summary>
    /// Print.
    /// </summary>
    interface IPrint
    {
        void Print();
    }
    /// <summary>
    /// Rectangle.
    /// </summary>
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
            this.Type = " Прямоугольник ";
        }
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    /// <summary>
    /// Square.
    /// </summary>
    class Square : Rectangle, IPrint
    {
        public Square(double size) : base(size, size)
        {
            this.Type = " Квадрат ";
        }
    }
    /// <summary>
    /// Circle.
    /// </summary>
    class Circle : Figure, IPrint
    {
        double rad;
        public Circle(double pr)
        {
            this.rad = pr;
            this.Type = " Круг ";
        }
        public override double Area()
        {
            double Result = Math.PI * this.rad * this.rad;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    /// <summary>
    /// Main class.
    /// </summary>
    class MainClass
    {
        static double proverka()
        {
            while (true)
            {

                int result;
                result = Convert.ToInt32(Console.ReadLine());
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
            }
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                double B, D;

                int swi = 0;
                Console.WriteLine("1 Прямоугольник, 2 Квадрат, 3 Круг");
                swi = Convert.ToInt32(Console.ReadLine());
                switch (swi)
                {
                    case 1:
                        Console.WriteLine("Введите длину");
                        B = proverka();
                        Console.WriteLine("Введите ширину");
                        D = proverka();
                        Rectangle rect = new Rectangle(B, D);
                        rect.Print();
                        break;
                    case 2:
                        Console.WriteLine("Введите сторону квадрата");
                        B = proverka();
                        Square sqr = new Square(B);
                        sqr.Print();
                        break;
                    case 3:
                        Console.WriteLine("Введите радиус");
                        D = proverka();
                        Circle cir = new Circle(D);
                        cir.Print();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод, попробуйте еще раз");
                        break;
                }
                Console.WriteLine("\n\nEnter any key for continue...");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}