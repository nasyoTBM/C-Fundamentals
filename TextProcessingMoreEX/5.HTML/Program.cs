using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            string articleComments = Console.ReadLine();

            Article article = new Article(articleTitle, articleContent);
            article.Comments = new List<string>();
            
            while (articleComments != "end of comments")
            {
                article.Comments.Add($"<div>{ Environment.NewLine}{articleComments}{Environment.NewLine}</div>");
                articleComments = Console.ReadLine();
            }
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Content);
            foreach (var item in article.Comments)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content  { get; set; }
        public List<string> Comments { get; set; }
        public Article(string title,string content)
        {
            Title = $"<h1>{Environment.NewLine}    {title}{Environment.NewLine}</h1>";
            Content = $"<article>{Environment.NewLine}    {content}{Environment.NewLine}</article>";
            
        }
    }
}
