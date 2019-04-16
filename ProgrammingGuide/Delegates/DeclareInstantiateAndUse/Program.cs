using System;
using System.Collections;
delegate void Del(string str);


namespace DeclareInstantiateAndUse
{
    using Bookstore;
    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }
        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }
    class Program
    {
        
        static void Notify(string name)
        {
            Console.WriteLine("Notification received for: {0}", name);
        }
        //create an instance of the delegate
        Del del1 = new Del(Notify);

        //C# 2.0 provides a simpler way to declare an instance of Del.
        Del del2 = Notify;

        //Instantiate Del by using an anonymous method.
        Del del3 = delegate(string name)
        {
            Console.WriteLine("Notification received for : {0}", name);
        };

        //Instantiate Del by using a lambda expression.
        Del del4 = name => {Console.WriteLine("Notification received for : {0}",name);};

        /////////////////////////////////////////////////////////////////////////////////////////

        
        static void PrintTitle(Book b)
        {
            System.Console.WriteLine("     {0}",b.Title);        
        }
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Lnaguage" , "Brian W. Kernighan and Dennis M. Ritchie", 19.95m , true);
            bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }

        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();

            AddBooks(bookDB);

            System.Console.WriteLine("Paperback Book Titles:");
            bookDB.ProcessPaperbackBooks(PrintTitle);

            PriceTotaller totaller = new PriceTotaller();
            bookDB.ProcessPaperbackBooks(totaller.AddBookToTotal);

            System.Console.WriteLine("Average Paperback Book Price : ${0:#.##}",totaller.AveragePrice());


        }
    }
}

namespace Bookstore
{    public struct Book
        {
            public string Title;
            public string Author;
            public decimal Price;
            public bool Paperback;
            public Book(string title , string author , decimal price , bool paperBack)
            {
                Title = title;
                Author = author;
                Price = price;
                Paperback = paperBack;
            }
        }

        public delegate void ProcessBookDelegate(Book book);

        public class BookDB
        {
            ArrayList list = new ArrayList();
            public void AddBook(string title , string author , decimal price , bool paperBack)
            {
                list.Add(new Book(title, author ,price , paperBack));
            }

            public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
            {
                foreach(Book b in list)
                {
                    if(b.Paperback)
                    {
                        processBook(b);
                    }
                }
            }
        }
}