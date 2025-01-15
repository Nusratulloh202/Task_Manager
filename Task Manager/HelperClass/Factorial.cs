using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class Factorial
    {
        public int InputNumberFactorial { get; set; }
        public void InputFactor()
        {
            string newFactorial;
            do
            {
                 Console.Write("Factorial hisoblanishi kerak sonni kiriting: ");
                 int inputNumberFactorial = int.Parse(Console.ReadLine());
                 InputNumberFactorial = inputNumberFactorial;
                 Console.WriteLine($"Siz kiritgan sonning factoriali:{FormFactorial(InputNumberFactorial)}.");
                 Console.WriteLine("Yana Factorial hisoblaysizmi(ha/yoq): ");
                 newFactorial = Console.ReadLine();
                while (newFactorial!="ha" && newFactorial!="yoq")
                {
                    Console.Write("Mumkin bo'lmagan buyruq kiritdingiz." +
                        "\nQayta urinib ko'ring:");
                    newFactorial = Console.ReadLine();
                }

            }
            while (newFactorial=="ha");

        }
        public int FormFactorial( int InputNumberFactorial)
        {
            int resultFactorial=1;
            for (int i = 1; i <= InputNumberFactorial; i++)
            {
                resultFactorial *= i;
            }
            return resultFactorial;
        }
    }
}
