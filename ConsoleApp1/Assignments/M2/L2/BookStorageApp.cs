using ConsoleApp1.Assignments.M2.L1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignments.M2.L2
{
    public class BookStorageApp
    {
        
        public static void Run()
        {
            var storageService = new BookStorageService();
            Console.WriteLine("Service book:...............");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            CreateBook(storageService);
            PresentBooks(storageService.ProseBooks);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                
        }

        public static void CreateBook(BookStorageService service)
        {
            var book = new Book();
            book.Title = Console.ReadLine();
            book.Author = Console.ReadLine();
            book.TheYearOfPublishment = Int32.Parse(Console.ReadLine());
            book.PublishingHouse = Console.ReadLine();
            book.Genre = (BookGenre)Int32.Parse(Console.ReadLine());
            service.ClassifyBookByGenre(book);
            Console.WriteLine("Add a new book.");

        }
        public static void PresentBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book: {book.Title}");
            }
        }

       
    }
}
