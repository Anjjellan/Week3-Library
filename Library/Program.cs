using Library;

Book book = new Book();
// This information is for one book in our library.
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "123-456-789";

book.DisplayInfo(); 

// This is another book in our library.
Book book1 = new Book();
book1.Title = "C# Methods and Classes";
book1.Author = "Microsoft";
book1.ISBN = "987-654-321";

book1.DisplayInfo();
