using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using LIbrary_Management_System.Model;
using LIbrary_Management_System.Dao;

namespace LIbrary_Management_System.Model
{
    class Book 
    {
        int bookid;
        string bookName;
        string authorName;
        int noOfCopies;
        float price;

        public Book(int bookid, string bookName, string authorName, int noOfCopies, float price)
        {
            this.Bookid = bookid;
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.NoOfCopies = noOfCopies;
            this.Price = price;
        }
        public Book()
        {

        }

        public int Bookid { get => bookid; set => bookid = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public int NoOfCopies { get => noOfCopies; set => noOfCopies = value; }
        public float Price { get => price; set => price = value; }

      
    }
}
