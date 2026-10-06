using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();

        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book1 = new Book("Ultimate C#", "Mircosoft", "2233445");

        book1.DisplayInfo();
    }

}