using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();

            int commandsCount = int.Parse(Console.ReadLine());
            while (commandsCount != 0)
            {
                string[] articleData = Console.ReadLine().Split(',').Select(s=>s.Trim()).ToArray();
                Article article = new Article(articleData[0], articleData[1], articleData[2]);
                articles.Add(article);
                commandsCount--;
            }
            string orderBy = Console.ReadLine();
            switch (orderBy)
            {
                case "author":
                    foreach (var article in articles.OrderBy(o => o.Author))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "title":
                    foreach (var article in articles.OrderBy(o => o.Title))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "content":
                    foreach (var article in articles.OrderBy(o => o.Content))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                default:
                    break;
            }
            




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
