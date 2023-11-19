using System;


class Program
{
    static void Main()
    {
        Book book =  new Book ("12 ,Nerden Bileceksiniz", "Ahmet kaya", 300);
        Console.WriteLine(book.Id);
        Console.WriteLine(book.Name);
        Console.WriteLine(book.AuthorName);
        Console.WriteLine(book.PageCount);
    }
}