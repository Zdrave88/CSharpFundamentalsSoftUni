using System;
using System.Reflection.Metadata;


class Program
{
    static void Main()
    {
        string[] textInput = Console.ReadLine().Split(", ");
        string title = textInput[0];
        string content = textInput[1];
        string author = textInput[2];

        Article article = new Article(title, content, author);

        int totalCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < totalCommands; i++)
        {
            string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            string action = command[0];
            string textAction = command[1];

            if (action == "Edit")
            {
                article.Edit(textAction);
            }
            if (action == "ChangeAuthor")
            {
                article.ChangeAuthor(textAction);
            }
            if (action == "Rename")
            {
                article.Rename(textAction);
            }
        }
        Console.WriteLine(article.ToString());
    }
}
class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string textAction)
    {
        Content = textAction;
    }

    public void ChangeAuthor(string textAction)
    {
        Author = textAction;
    }

    public void Rename(string textAction)
    {
        Title = textAction;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }

}