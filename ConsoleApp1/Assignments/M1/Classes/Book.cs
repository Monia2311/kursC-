namespace ConsoleApp1.Assignments.Classes
{
    public class Book
    {
        public string Title;
        public int NumberOfPages;
        public string Author;

        public Book(string title, int numberOfPages, string author)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            Author = author;
        }

        public Book()
        {
            Title = "Microsoft Visual C# 2022 Krok po kroku";
            NumberOfPages = 910;
            Author = "Sharp John";
        }

        public Book(string title)
        {
            Title = title;
            NumberOfPages = 1000;
            Author = "Ktoś";
        }

        public void Present()
        {
            Console.WriteLine("Tytuł książki: "+Title);
            Console.WriteLine("Autor: "+Author);
            Console.WriteLine("Liczba stron: "+NumberOfPages);
        }

        public int EditionYears(int NowYear, int EditionYear)
        {
            return NowYear - EditionYear;
        }
    }
}
