using Class_Work.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Work.Interface
{
    interface IAccount
    {
        public bool PasswordChecker(string Password);
        public void ShowInfo();

    }
}
