using System;
using System.Collections.Generic;
using System.Text;
using LIbrary_Management_System.Model;

namespace LIbrary_Management_System.Dao
{
    interface MemberDao 
    {
        bool AddBook(Book b);
        bool DeleteBook(int bookid);
        bool UpdateBook(int id, string bknm, string anm);
        List<Book> getAllBooks();
        Book getBookById(int id);
    }
}
