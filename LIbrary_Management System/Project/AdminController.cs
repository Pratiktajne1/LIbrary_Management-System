using LIbrary_Management_System.Dao;
using LIbrary_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIbrary_Management_System.Project
{
    class AdminController
    {
        public void Display()
        {


           
            DBConnection.GetConnection();
            // con.Open();
            try
            {
                Console.WriteLine("========================================================\n");
                Console.WriteLine("Press 1. -> Search Book\nPress 2. -> Add Book\nPress 3. -> Remove Book\nPress 4. Update Book\nPress 5. -> Member Information\nPress 6. -> Log Out\n");
                Console.WriteLine("========================================================\n");
                BookDao v = new BookDaolmpl();
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Enter the id");
                        int s = int.Parse(Console.ReadLine());




                        /*
                         *     code
                         */
                        break;
                    case 2:
                        bool b = v.AddBook(new Book());
                        if (b)
                        {
                            Console.WriteLine("Book Add Successfully");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter book Id");
                        int f = int.Parse(Console.ReadLine());
                        bool h = v.DeleteBook(f);
                        if (h)
                        {
                            Console.WriteLine("Book Removed Successfully");
                        }

                        break;
                    case 4:
                        /*
                         *     code
                         */
                        break;
                    case 5:
                        /*
                         *    code
                         */
                        break;
                    case 6:
                        /*
                         *    code
                         */
                        break;
                    default:
                        Console.WriteLine("Enter valid number");
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
