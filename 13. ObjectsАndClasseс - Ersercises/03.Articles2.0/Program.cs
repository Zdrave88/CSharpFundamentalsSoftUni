using System;
using System.Reflection.Metadata;


class Program
{
    static void Main()
    {
        List<Article> articles = new List<Article>();

        int totalCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalCommands; i++)
        {
            string[] textInput = Console.ReadLine().Split(", ");
            string title = textInput[0];
            string content = textInput[1];
            string author = textInput[2];

            Article article = new Article(title, content, author);
            articles.Add(article);
        }

        foreach (Article article in articles)
        {
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}