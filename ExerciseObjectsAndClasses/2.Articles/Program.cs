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
            string input = Console.ReadLine();
            string[] articleData = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Article article = new Article(articleData[0], articleData[1], articleData[2]);
            int commandsCount = int.Parse(Console.ReadLine());
            while (commandsCount!=0)
            {
                string[] command = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0]=="Edit")
                {
                    article.Edit(command[1]);
                }
                else if(command[0]=="Rename")
                {
                    article.Rename(command[1]);
                }
                else if (command[0]=="ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                commandsCount--;
            }
            Console.WriteLine(article.ToString());


            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
