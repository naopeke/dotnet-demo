using System.Collections.Generic;
using Summaries.Data;

namespace Summaries.DateStart{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}