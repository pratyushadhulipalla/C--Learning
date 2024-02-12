// See https://aka.ms/new-console-template for more information

namespace classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "world";
            book1.author = "Jack";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
        
    }
}