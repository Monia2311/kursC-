using ConsoleApp1.Assignments.M2.L1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments.M2.L2
{
    public class BookStorageService
    {
        public List<Book> HorrorBooks;
        public List<Book> ProseBooks;
        public List<Book> ThrillerBooks;
        public List<Book> FictionBooks;
        public List<Book> DramaBooks;

        public BookStorageService()
        {
            HorrorBooks = new List<Book>();
            ProseBooks = new List<Book>();
            ThrillerBooks = new List<Book>();
            FictionBooks = new List<Book>();
            DramaBooks = new List<Book>();
        }

        public void ClassifyBookByGenre(Book book)
        {
            switch(book.Genre)
            {
                case BookGenre.HORROR:
                    HorrorBooks.Add(book);
                    break;
                case BookGenre.PROSE:
                    ProseBooks.Add(book);
                    break;
                case BookGenre.THRILLER:
                    ThrillerBooks.Add(book);
                    break;
                case BookGenre.FICTION:
                    FictionBooks.Add(book);
                    break;
                case BookGenre.DRAMA:
                    DramaBooks.Add(book);
                    break;
                default:
                    Console.WriteLine("This genere do not exist.");
                    break;
            }

        }

    public void ClearBookList()
        {
            HorrorBooks.Clear();
            ProseBooks.Clear();
            ThrillerBooks.Clear();
            FictionBooks.Clear();
            DramaBooks.Clear();
        }


    }
}
