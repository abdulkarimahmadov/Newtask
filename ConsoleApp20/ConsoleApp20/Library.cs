using System;

public class Library : IEntity
{
    private Book[] books;
    private int bookCount;

    public Library(int bookLimit)
    {
        BookLimit = bookLimit;
        books = new Book[bookLimit];
        bookCount = 0;
    }

    public int Id { get; }

    public int BookLimit { get; }

    public void AddBook(Book book)
    {
        if (bookCount >= BookLimit)
        {
            throw new CapacityLimitException("Kitab limitine catif.");
        }

        if (Array.Exists(books, b => b != null && b.Name == book.Name && !b.IsDeleted))
        {
            throw new AlreadyExistsException("Eyniadli kitab var dana iki gozum.");
        }

        books[bookCount++] = book;
    }

    public Book GetBookById(int id)
    {
        Book foundBook = Array.Find(books, b => b != null && b.Id == id && !b.IsDeleted);

        if (foundBook == null)
        {
            throw new NotFoundException($"el cek de bu  ID {id} -li kitab yoxdu .");
        }

        return foundBook;
    }
}
