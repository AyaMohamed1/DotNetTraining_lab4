
using lab4;


class LibraryEngine
{
    //User Defined Delegate Datatype
    public delegate string MyDelegate(Book B);
    public static void ProcessBooks(List<Book> bList, MyDelegate fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }

    //BCL Delegates
    public static void ProcessBooks2(List<Book> bList, Func<Book, string> fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }

    public static void Main(string[] args)
    {
        Book b1 = new Book("123", "Java intro", new string[] { "auth1", "auth2"}, new DateTime(2022, 1, 1), 1.50M);
        Book b2 = new Book("345", "C++ intro", new string[] { "b2 m1", "b2 m2" }, new DateTime(2023, 2, 1), 5.50M);
        Book b3 = new Book("567", "Python intro", new string[] { "b3 auth1", "b3 auth2" }, new DateTime(2012, 4, 18), 3.20M);
        Book b4 = new Book("789", "C# intro", new string[] { "b4 auth1", "b4 auth2" }, new DateTime(2020, 7, 4), 7.40M);

        //Book[] myBooks = new Book[4]{b1, b2, b3, b4};
        List<Book> myBooks = new List<Book>();
        myBooks.Add(b1);
        myBooks.Add(b2);
        myBooks.Add(b3);
        myBooks.Add(b4);

        foreach(Book book in myBooks)
        {
            Console.WriteLine(book);
        }

        // User Defined Delegate
        Console.WriteLine("**********User Defined Delegate Datatype**********\n\nGetTitle:");
        MyDelegate fPtr1 = BookFunctions.GetTitle;
        ProcessBooks(myBooks, fPtr1);

        //BCL Delegates
        Console.WriteLine("\n**********BCL Delegates**********\n\nGetAuthors:");
        Func<Book, string> fPtr2 = BookFunctions.GetAuthors;
        ProcessBooks2(myBooks, fPtr2);

        //Anonymous Method (GetISBN)
        Console.WriteLine("\n**********Anonymous Method**********\n\nGetISBN:");
        //Predicate <Book> fPtr3 = delegate (Book b){
        //Console.WriteLine(b.ISBN);};


        MyDelegate fPtr4;
        
        fPtr4 = delegate (Book b) {
            return (b.ISBN);
        };

        foreach (Book B in myBooks)
        {
            Console.WriteLine(fPtr4(B));
        }

        //anotherway
        Console.WriteLine("\n\nAnotherway\n\n");
        ProcessBooks(myBooks, delegate (Book b) {
            return (b.ISBN);
        });

        //Anonymous Method (GetISBN)
        Console.WriteLine("\n**********Lambda Expression**********\n\nGetPublicationDate:");
        MyDelegate fPtr5;
        fPtr5 = b => b.PublicationDate.ToString();

        foreach (Book B in myBooks)
        {
            Console.WriteLine(fPtr5(B));
        }

        //anotherway
        Console.WriteLine("\n\nAnotherway\n\n");
        ProcessBooks(myBooks, b => b.PublicationDate.ToString());



    }

}


