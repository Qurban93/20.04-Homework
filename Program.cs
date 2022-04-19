using Class_Work.Models;
using System;

namespace Class_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FullName = "Zakiri Qurban";
            user.EMail = "Qurban1993@gmail.com";
            

            Console.WriteLine("Parolu daxil edin");
            string password = Console.ReadLine();
            Console.WriteLine(user.PasswordChecker(password));

        }
    }
}
