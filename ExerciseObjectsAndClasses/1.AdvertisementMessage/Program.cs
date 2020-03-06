using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());

            while (messagesCount!=0)
            {
                Console.WriteLine(AdvertisementMessage.GenerateText());
                messagesCount--;
            }
                
            

        }
        static class AdvertisementMessage
        {
            private static Random rand = new Random();

            private static List<string> Phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of itscategory.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            private static List<string> Events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of theresults!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            private static List<string> Authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            private static List<string> Cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            public static string GenerateText()
            {
                string phrase = string.Empty;
                string singleEvent = string.Empty;
                string author = string.Empty;
                string city = string.Empty;

                phrase = Phrases[rand.Next(Phrases.Count)];
                singleEvent = Events[rand.Next(Events.Count)];
                author = Authors[rand.Next(Authors.Count)];
                city = Cities[rand.Next(Cities.Count)];

                return $"{phrase} {singleEvent} {author} – {city}.";
            }
        }
    }
}
