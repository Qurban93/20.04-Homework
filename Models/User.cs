using Class_Work.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Work.Models
{
    class User : IAccount
    {
        public string FullName;
        public string EMail;
        private string _password;
        public string Password;
        

        public bool PasswordChecker(string Password)
        {
            
            if ( Password.Length  > = 8 )
            {

                foreach (char item in Password)
                {
                    bool check1 = false;
                    bool check2 = false;
                    bool check3 = false;

                    if (char.IsDigit(item))
                    {
                        check1 = true;

                    }else if (char.IsLower(item))
                    {
                        check2 = true;
                    }else if (char.IsUpper(item))
                    {
                        check3 = true;

                    }
                    else { Console.WriteLine("Duzgun daxil et !"); }

                    if (check1 && check2 && check3)
                    {
                        return true;
                    }
                    

 
                }
                
            }
            Console.WriteLine("Password minimum 8 simvoldan ibaret olmalidi");
            return false;



            
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Tam Adi {FullName} Email addressi {EMail}");


        }
    }
}
