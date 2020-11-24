using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBooksDal
    {
        BooksDTO GetBookById(int id);
        List<BooksDTO> GetAllBooks();
        BooksDTO UpdateMovie(BooksDTO book);
        BooksDTO CreateMovie(BooksDTO book);
        void DeleteBook(int id);
    }
}
