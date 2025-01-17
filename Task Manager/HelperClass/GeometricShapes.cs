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
        public const double pe = 3.14;


        public void GeometricShapVoid()
        {
            Console.WriteLine("1. To'rtburchak ustida amallar");
            Console.WriteLine("2. Doira ustida amallar");
            Console.Write("Tanlovingizni kiriting: ");

            short GeometrikSelection = short.Parse(Console.ReadLine());
            string tanlovRectangle;
            if (GeometrikSelection == 1)
            {
                do
                {
                    Console.Write("To'g'ri to'rtburchakni balandligini kiriting:");
                    if (!double.TryParse(Console.ReadLine(), out double rectangleHeight))
                    {
                        Console.WriteLine("Noto'g'ri qiymat kiritildi. Qayta urinib ko'ring.");
                        return;
                    }
                    Console.Write("To'g'ri to'rtburchakni enini kiriting:");
                    if (!double.TryParse(Console.ReadLine(), out double rectangleWeight))
                    {
                        Console.WriteLine("Noto'g'ri qiymat kiritildi. Qayta urinib ko'ring.");
                        return;
                    }
                    RectangleHeight = rectangleHeight;
                    RectangleWeight = rectangleWeight;
                    Console.WriteLine($"To'rtburchak yuzasi:{RectangleYuza(RectangleHeight, RectangleWeight)}" +
                       $"\nTo'rtburchak perimetri:{RectanglePerimetr(RectangleHeight, RectangleWeight)}");
                    Console.WriteLine("To'g'ri to'rtburchak buyicha yana masala ishlaymizmi(ha/yoq)");
                    tanlovRectangle =Console.ReadLine()?.ToLower();
                } while (tanlovRectangle == "ha");

            }
            string tanlovCircle;

            if (GeometrikSelection == 2)
                do
                {
                    Console.Write("Aylana Radiusini kiriting:");
                    double circleRadius = double.Parse(Console.ReadLine());
                    CircleRadius = circleRadius;
                    Console.WriteLine($"Aylana yuzasi:{CircleYuza(circleRadius, pe)}" +
                        $"\nAylana Yoy uzunligi:{CircleYoyUzunligi(circleRadius, pe)}");
                    Console.WriteLine("\nAylana buyicha yana masala ishlaymizmi(ha/yoq)");
                    string tanlovCircleInput = Console.ReadLine();
                    tanlovCircle = Console.ReadLine()?.ToLower();
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
