using System.Xml.Linq;

namespace _03.SchoolLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                                .Split("&")
                                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" | ");
                string action = arguments[0];
                if (action == "Add Book")
                {
                    string bookName = arguments[1];
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (action == "Take Book")
                {
                    string bookName = arguments[1];
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                }
                else if (action == "Swap Books")
                {
                    string book1 = arguments[1];
                    string book2 = arguments[2];
                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        int book1index = books.IndexOf(book1);
                        int book2index = books.IndexOf(book2);
                        books.Insert((int)book1index, book2);
                        books.RemoveAt((int)book1index + 1);
                        books.Insert((int)book2index, book1);
                        books.RemoveAt((int)book2index + 1);
                    }
                }
                else if (action == "Insert Book")
                {
                    string bookName = arguments[1];
                    if (!books.Contains(bookName))
                    {
                        books.Add(bookName);
                    }
                }
                else if (action == "Check Book")
                {
                    int index = int.Parse(arguments[1]);
                    if (index < 0 || index > books.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(books[index]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
