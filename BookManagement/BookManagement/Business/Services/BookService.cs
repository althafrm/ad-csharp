using BookManagement.Data.Models;
using BookManagement.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Business.Services
{
    public class BookService
    {
        private readonly BookRepository _repository;
        public BookService()
        {
            _repository = new BookRepository();
        }
        public List<Book> GetBooks()
        {
            return _repository.GetAllBoks();
        }

        public void AddBook(string name, string isbn, string author)
        {
            _repository.AddBook(name, isbn, author);
        }
    }
}
