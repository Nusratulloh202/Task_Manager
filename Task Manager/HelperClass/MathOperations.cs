using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class MathOperations
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public char Operations { get; set; }

        public void MathOperation()
        {
            string newMathProblem;
            do
            {
            Console.Write("1 sonni kiriting:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("2 sonni kiriting:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Oraliq ishorani kiriting: ");
            char operation = char.Parse(Console.ReadLine());
            while (operation!='+'&& operation!='-' && operation!='*' && operation != '/')
            {
                Console.Write("Oraliq ishora xato qayta kiriting: ");
                operation = char.Parse(Console.ReadLine());
            }
            Operations = operation;
            Console.WriteLine($"Javob: {ResultMathProblem(firstNumber, secondNumber, Operations)}");
            do
            {
                Console.WriteLine("Yana misol ishlaysizmi(ha/yoq)");
                newMathProblem = Console.ReadLine().ToLower();
                    
            }
            while (newMathProblem!="ha" && newMathProblem!="yoq");
                
                if (newMathProblem == "yoq")
                    break;
            }
            while (newMathProblem=="ha");



        }

        private double ResultMathProblem(double a, double b, char c)
        {

            double resultProblem = c switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
            };


            return resultProblem;

        }
    }
}
