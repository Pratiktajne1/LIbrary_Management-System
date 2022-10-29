using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using LIbrary_Management_System.Model;
using LIbrary_Management_System.Project;

namespace LIbrary_Management_System.Dao
{
    class BookDaolmpl : BookDao
    {
        public Book GetBookById(int id)
        {
            Book b = new Book();
            return b;
        }
        public bool AddBook(Book bk)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("insert into Book values(@i,@bknm,@anm,@price,@no)", con);
                    cmd.Parameters.AddWithValue("@i", bk.Bookid);
                    cmd.Parameters.AddWithValue("@bknm", bk.BookName);
                    cmd.Parameters.AddWithValue("@anm", bk.AuthorName);
                    cmd.Parameters.AddWithValue("@price", bk.Price);
                    cmd.Parameters.AddWithValue("@no", bk.NoOfCopies);
                    cmd.ExecuteNonQuery();
                    return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
       
        

        public bool DeleteBook(int bookid)
        {
            object ob = GetBookById(bookid);
            if (ob == null)
            {
                return false;

            }
            else
            {
                SqlConnection con = null;
                try
                {
                    Console.WriteLine("********************Add New Book**********************");
                    con = DBConnection.GetConnection();
                    con.Open();
                    SqlCommand command = new SqlCommand("delete from Book where Book_id=@id", con);
                    command.Parameters.AddWithValue("@id", bookid);

                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                        return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
                return false;
            }
        }
        public List<Book> GetAllBooks()
        {
            List<Book> booklist = new List<Book>();

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("select * from Book", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        int bid = (int)r[0];
                        string bnm = (string)r[1];
                        string anm = (string)r[2];
                        int price = (int)r[3];
                        int copies = (int)r[4];
                        Book bk = new Book(bid, bnm, anm, price, copies);
                        booklist.Add(bk);
                    }
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return booklist;
        }
        
        public bool UpdateBook(int id, string bknm, string anm)
        {
            SqlConnection con = null;
            try
            {
                Console.WriteLine("********************Edit Book**********************");
                con = DBConnection.GetConnection();

                Console.WriteLine("Enter bookid you want update");
                int bid = int.Parse(Console.ReadLine());
                con.Open();
                object ob = GetBookById(bid);
                if (ob == null)
                {
                    return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update Book set book_name=@bknm,author_name=@anm,price=@price where book_id=@i", con);
                  /*  Console.WriteLine("enter new bookname");
                    string bookname = Console.ReadLine();
                    Console.WriteLine("enter new authorname");
                    string aname = Console.ReadLine();
                    Console.WriteLine("Enter new price");
                    float pr = float.Parse(Console.ReadLine());


                    cmd.Parameters.AddWithValue("@i", bid);
                    cmd.Parameters.AddWithValue("@bknm", bookname);
                    cmd.Parameters.AddWithValue("@anm", aname);
                    cmd.Parameters.AddWithValue("@price", pr);

                    int count = cmd.ExecuteNonQuery();*/
                    Console.WriteLine("Record updated successfully");
                    return true;
                }


            }

            catch (Exception e)
            {
                    Console.WriteLine(e.Message);
            }
            finally
            {
                    con.Close();
            }
            return false;
        }

       
    }
}

