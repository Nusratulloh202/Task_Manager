using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class GeometricShapes
    {
        public double CircleRadius { get; set; }
        public double RectangleHeight { get; set; }
        public double RectangleWeight { get; set; }
        public short GeometricSelection { get; set; }
        public const double pe = 3.14;


        public void GeometricShapVoid()
        {
            Console.WriteLine("1.Doira ustida amallar,\n2.To'rtburchak utida amallar");
            short geometrikSelection = short.Parse(Console.ReadLine());
            string tanlovRectangle;
            if (geometrikSelection == 1)
            {
                do
                {
                    Console.Write("To'g'ri to'rtburchakni balandligini kiriting:");
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.Write("To'g'ri to'rtburchakni enini kiriting:");
                    double rectangleWeight = double.Parse(Console.ReadLine());
                    RectangleHeight = rectangleHeight;
                    RectangleWeight = rectangleWeight;
                    Console.WriteLine($"To'rtburchak yuzasi:{RectangleYuza}" +
                       $"\nTo'rtburchak perimetri:{RectanglePerimetr}");
                    Console.ReadLine();
                    Console.WriteLine("To'g'ri to'rtburchak buyicha yana masala ishlaymizmi(ha/yoq)");
                    string tanlovCircleInput = Console.ReadLine();
                    tanlovRectangle = tanlovCircleInput;
                } while (tanlovRectangle == "ha");

            }
            string tanlovCircle;

            if (geometrikSelection == 2)
                do
                {
                    Console.Write("Aylana Radiusini kiriting:");
                    double circleRadius = double.Parse(Console.ReadLine());
                    CircleRadius = circleRadius;
                    Console.WriteLine($"Aylana yuzasi:{CircleYuza(circleRadius, pe)}" +
                        $"\nAylana Yoy uzunligi:{CircleYoyUzunligi(circleRadius, pe)}");
                    Console.ReadLine();
                    Console.WriteLine("Aylana buyicha yana masala ishlaymizmi(ha/yoq)");
                    string tanlovCircleInput = Console.ReadLine();
                    tanlovCircle = tanlovCircleInput;
                } while (tanlovCircle == "ha");

        }

    
        
        private double RectanglePerimetr(double a, double b)
        {
            double c = (a + b)*2;
            return c;
        }
        private double RectangleYuza(double a, double b)
        {
            double c = a*b;
            return c;
        }
        private double CircleYuza(double r, double pe)
        {
            double S = pe * r * r;
            return S;
        }
        private double CircleYoyUzunligi(double r, double pe)
        {
            double L = 2 * pe * r;
            return L;
        }

    }
}
