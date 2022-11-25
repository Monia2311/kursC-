using ConsoleApp1.Assignments.Classes;

namespace ConsoleApp1.Assignments.M1
{
    public class BookConstructors
    {
        public static void Test()
        {
            var book1 = new Book();
            book1.Title = "Tytuł 1";
            book1.NumberOfPages = 90;
            book1.Author = "Jan Kowalski";

            var book2 = new Book("Tytuł 2", 99, "Anna Nowak");

            var book3 = new Book("Tutuł 3");

            book1.Present();
            book2.Present();
            book3.Present();
            Console.WriteLine(book1.EditionYears(2022, 1999));
        }

        public static void Test2()
        {
            string Book5 = "tytuł 5";
            string Book6 = "tytuł 6";
            // Book book = new Book(Book5);
            // book.Present();
            Console.WriteLine(Book5 + Book6);
        }
    }
}
