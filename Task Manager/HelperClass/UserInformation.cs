using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.HelperClass
{
    internal class UserInformation
    {
        public string UserName { get; set; }
        public string Surname { get; set; }
        public int UserAge { get; set; }
        public string UserAddress { get; set; }
        public string FavoriteAnimal { get; set; }
        public string FavoriteFood { get; set; }



        List<UserInformation> PeopleList = new List<UserInformation>();
        public void AddUser()
        {
            string NewUser;
            do
            {
                Console.Write("Ismingizni kiriting:");
                string userName = Console.ReadLine();

                Console.Write("Familiyangizni kiriting:");
                string surname = Console.ReadLine();

                Console.Write("Yashash manzilingizni kiriting(viloyat):");
                string userAddress = Console.ReadLine();

                Console.Write("Yoshingizni kiriting:");
                int userAge = int.Parse(Console.ReadLine());

                Console.Write("Yoqtirgan hayvoningizni kiriting:");
                string favoriteAnimal = Console.ReadLine();

                Console.Write("Yoqtirgan taomingizni kiriting:");
                string favoriteFood = Console.ReadLine();
                UserInformation newUserInformation = new UserInformation
                {
                    UserName = userName,
                    Surname = surname,
                    UserAddress = userAddress,
                    UserAge = userAge,
                    FavoriteAnimal = favoriteAnimal,
                    FavoriteFood = favoriteFood,
                };
                PeopleList.Add(newUserInformation);

                Console.Write("Yangi shaxs ma'lumotlarini kiratismi(ha/yoq):");
                NewUser = Console.ReadLine().ToLower();
                while (NewUser != "ha" && NewUser != "yoq")
                {
                    Console.Write("Iltimos belgilangan so'zni kiriting:");
                    NewUser = Console.ReadLine();
                }

            }
            while (NewUser == "ha");
            DisplayAllUser();
        }





        public void DisplayAllUser()
        {
            Console.WriteLine("\nSaqlangan foydalanuvchilar:");
            foreach (var user in PeopleList)
            {
                Console.WriteLine($"Ism: {user.UserName,-13}, Familiya: {user.Surname, -12}, " +
                                  $"Manzil: {user.UserAddress, -12}, Yosh: {user.UserAge,-3}, " +
                                  $"Hayvon: {user.FavoriteAnimal,-12}, Taom: {user.FavoriteFood,-12}");
            }
        }
    }
}
