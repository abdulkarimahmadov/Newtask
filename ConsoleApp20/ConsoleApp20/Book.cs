using System;

public class Book : IEntity
{
    private static int idCounter = 1;

    public Book(string name, string authorName, int pageCount)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(authorName) || pageCount <= 0)
        {
            throw new ArgumentException("Name, authorName, pageCount kitab ucun lazimdir.");
        }

        Id = idCounter++;
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
        IsDeleted = false;
    }

    public int Id { get; }

    public string Name { get; }

    public string AuthorName { get; }

    public int PageCount { get; }

    public bool IsDeleted { get; private set; }

    public void Delete()
    {
        IsDeleted = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Book ID: {Id}, Name: {Name}, Author: {AuthorName}, PageCount: {PageCount}, IsDeleted: {IsDeleted}");
    }

    public static bool operator >(Book b1, Book b2)
    {
        return b1.PageCount > b2.PageCount;
    }

    public static bool operator <(Book b1, Book b2)
    {
        return b1.PageCount < b2.PageCount;
    }
}

