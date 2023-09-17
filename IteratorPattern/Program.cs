using IteratorPattern;

var library = new Library();
library.Add(new Book("Robert Martin", "Clean Architecture", new DateTime(2017, 1, 1)));
library.Add(new Book("Robert Martin", "Clean Code", new DateTime(2008, 1, 1)));
library.Add(new Book("Chris Richardson", "Microservices Patterns", new DateTime(2018, 1, 1)));
library.Add(new Book("Martin Fowler", "Refactoring: Improving the Design of Existing Code", new DateTime(1999, 1, 1)));
library.Add(new Book("Kent Beck", "Extreme Programming Explained", new DateTime(2004, 1, 1)));

foreach (var iterator in library.GetOrderByAuthorIterator())
{
    Console.WriteLine(
        $"Author: {iterator.Author}," +
        $"Title: {iterator.Title}," +
        $"Year: {iterator.Year}");
}

Console.WriteLine();

foreach (var iterator in library.GetOrderTitleIterator())
{
    Console.WriteLine(
        $"Author: {iterator.Author}," +
        $"Title: {iterator.Title}," +
        $"Year: {iterator.Year}");
}

Console.WriteLine();

foreach (var iterator in library.GetOrderByYearIterator())
{
    Console.WriteLine(
        $"Author: {iterator.Author}," +
        $"Title: {iterator.Title}," +
        $"Year: {iterator.Year}");
}