using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("Press any key to continue");
            //Console.ReadKey();

            WELCOME t = new WELCOME();
            t.Welcome();
            // t.password();

           // int numOfQuestion = 10;
           // int repons=10;
            //numOfQuestion ;

            int limit = 0;
            int num = 1;
                
                
                
                string userAnswer;
                int score=0;

               

                //randomize the order of the question
               // int l;
               // Random rnd = new Random();
               // l = rnd.Next(0, 9);
                //call method in class Florida
                Florida q = new Florida();
            Console.Write("1.");
            Console.WriteLine(q.Quest[limit]);
            //Console.WriteLine();
            userAnswer = Console.ReadLine();
            for (int i = 0;i==limit; i++)
            {

                num++;

                if (limit == 10)
                {
                    break;
                }


                if (userAnswer == q.Ans[limit])
                {
                    Console.WriteLine();
                    limit++;
                    //score++;
                    Console.Write("{0}.", num);
                    Console.WriteLine(q.Quest[limit]);
                    userAnswer = Console.ReadLine();
                   // Console.WriteLine();
                    //limit++;
                    score++;
                }

                else if (userAnswer != q.Ans[limit])
                {
                    Console.WriteLine();
                    limit++;
                    Console.Write("{0}.", num );
                    Console.WriteLine(q.Quest[limit]);
                    
                    userAnswer = Console.ReadLine();
                   // Console.WriteLine();
                    //limit++;

                }

               

            }

            t.score();
            Console.Write("\t\t\t\t\t "+score);
            Console.Write(" / "+11);



            Console.ReadLine();































        }
            
        
    }
}
