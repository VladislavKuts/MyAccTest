using System;
using System.Collections.Generic;
using System.Text;

namespace MyAccTest
{
    class UserData
    {
        public String correctPass = "qwerty12345";
        Random rand = new Random();

        public String GetUniqueEmail()
        {
            return "user"+rand.Next(1000, 9999).ToString()+"@" +"mail.co";
        }

        

    }
}
