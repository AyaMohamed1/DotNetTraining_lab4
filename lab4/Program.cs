
using lab4;


class Program
{

    public static void Main(string[] args)
    {
        List<Book> myBooks = new List<Book>();
        myBooks.Add(new Book("123", "Java intro", new string[] { "auth1", "auth2" }, new DateTime(2022, 1, 1), 1.50M));
        myBooks.Add(new Book("345", "C++ intro", new string[] { "b2 m1", "b2 m2" }, new DateTime(2023, 2, 1), 5.50M));
        myBooks.Add(new Book("567", "Python intro", new string[] { "b3 auth1", "b3 auth2" }, new DateTime(2012, 4, 18), 3.20M));
        myBooks.Add(new Book("789", "C# intro", new string[] { "b4 auth1", "b4 auth2" }, new DateTime(2020, 7, 4), 7.40M));

        foreach(Book book in myBooks)
        {
            Console.WriteLine(book);
        }

        // User Defined Delegate
        Console.WriteLine("**********User Defined Delegate Datatype**********\n\nGetTitle:");
        MyDelegate fPtr1 = BookFunctions.GetTitle;
        LibraryEngine.ProcessBooks(myBooks, fPtr1);

        //BCL Delegates
        Console.WriteLine("\n**********BCL Delegates**********\n\nGetAuthors:");
        Func<Book, string> fPtr2 = BookFunctions.GetAuthors;
        LibraryEngine.ProcessBooks2(myBooks, fPtr2);

        //Anonymous Method (GetISBN)
        Console.WriteLine("\n**********Anonymous Method**********\n\nGetISBN:");
        LibraryEngine.ProcessBooks(myBooks, delegate (Book b) {
            return (b.ISBN);
        });

        //Lambda Expression (GetPublicationDate)
        Console.WriteLine("\n**********Lambda Expression**********\n\nGetPublicationDate:");
        LibraryEngine.ProcessBooks(myBooks, b => b.PublicationDate.ToString());



    }

}


