using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class PasswordClass
    {
        private  string CorrectPassword = "AC1929891";

        public void ValidatePassword()
        {
            Console.WriteLine("Assalomu alaykum\n" +
                 "'Vazifalar Menejeri' loyihamga xush kelibsiz.\n");
            string passwordTaskManager;
            do
            {
                Console.Write("Loyihamizga kirish uchun\nMaxfiy kodni kiriting:");
                passwordTaskManager = Console.ReadLine();

                if (passwordTaskManager != CorrectPassword)
                {
                    Console.Write("\nXato kod! Qayta urinib ko'ring.\n\n");
                }
            }
            while (passwordTaskManager != CorrectPassword);

            Console.WriteLine("\nMaxfiy kod to'g'ri. Loyihaga xush kelibsiz!");
            Console.ReadKey();
            Console.Clear();

        }
        public string InputOldPassword { get; set; }
        public void OldPasswordTekshir()
        {
            do
            {
                Console.Write("Eski parolni kiriting:");
                string inputOldPassword = Console.ReadLine();
                InputOldPassword = inputOldPassword;

            } while (InputOldPassword != CorrectPassword);
            Console.WriteLine("Parol tasdiqlandi.");
            

        }
        public string NewPasswordUpdate(string newPass)
        {
            CorrectPassword = newPass;
            return CorrectPassword;
        }
    }
}
