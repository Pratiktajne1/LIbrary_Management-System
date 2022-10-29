using System;
using System.Collections.Generic;
using System.Text;

namespace LIbrary_Management_System.Project
{
    class LogPage
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("=================================================================");
                Console.WriteLine("Welcome to Library");
                Console.WriteLine("=================================================================");
                Console.WriteLine();
                Console.WriteLine("press 1  :- Log In\npress 2  :- Log out");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                          AdminController A = new AdminController();
                        A.Display();
                        Console.WriteLine("===========================================================");
                        break;
                    case 2:
                        /*
                              Code
                         */
                      



                        break;
                    default:
                        Console.WriteLine("invalid value\nEnter 1 or 2 only");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

