using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class PaswordInsert
    {
        PasswordClass passwordClass1 = new PasswordClass();
        public string TanlovPassword { get; set; }
        public string InputPasswordTekshir { get; set; }
        public void PasswordInsertUpdate()
        {
            do
            {
                Console.WriteLine("Parol o'zgartirasizmi (ha/yoq):");
                string tanlovPassword = Console.ReadLine();
                TanlovPassword = tanlovPassword;
            }
            while (TanlovPassword != "ha" && TanlovPassword != "yoq");
            if (TanlovPassword == "ha")
            {
                passwordClass1.OldPasswordTekshir();
                Console.WriteLine("Yangi parolni kiriting:");
                string newpasss = Console.ReadLine();
                Console.WriteLine($"Yangi parol o'rnatildi. " +
                    $"Hozirgi parol: {passwordClass1.NewPasswordUpdate(newpasss)}");
                Console.ReadLine();

            }
            
        }
    }
}
