using System;
using System.Collections.Generic;
using System.Text;

namespace guessing
{
    class WELCOME
    {
       public void Welcome()
        {
            Console.WriteLine("\t\t\t\t\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\t\t\t\t\t@@@@@@@@@@@@ QUIZETA @@@@@@@@@@@@");
            Console.WriteLine("\t\t\t\t\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }

        public void password()
        {
            string username;
            string pass;
            Console.WriteLine("Please Enter name ");
            username = Console.ReadLine();
            Console.WriteLine("Enter pasword");
            pass = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\t##############");
            Console.WriteLine("\t\t\t\t\t#   {0}    #", username);
            Console.WriteLine("\t\t\t\t\t##############");

        }

        public void score()
        {
            Console.WriteLine("\t\t\t\t\t##############");
            Console.WriteLine("\t\t\t\t\t#   SCORE    #" );
            Console.WriteLine("\t\t\t\t\t##############");
        }

    }
}
