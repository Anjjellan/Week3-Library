using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs ftom the class name
        Book book = new Book("C# for beginners", "BillGates", "1234567");

        book.DisplayInfo();
    }
}
