using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = Console.ReadLine();
            string input = Console.ReadLine();
            while (input !="Complete")
            {
                string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        mail = mail.ToUpper();
                        Console.WriteLine(mail);
                    }
                    else
                    {
                        mail = mail.ToLower();
                        Console.WriteLine(mail);
                    }
                }

                else if (command[0] == "GetDomain")
                {
                    GetDomain(mail, int.Parse(command[1]));
                }
                else if (command[0] == "GetUsername")
                {
                    GetUserName(mail);
                }
                else if (command[0] == "Replace")
                {
                    Replace(mail, char.Parse(command[1]));
                }
                else if (command[0] == "Encrypt")
                {
                    Encrypt(mail);
                }
                input = Console.ReadLine();
            }
        }
      
        static void GetDomain(string mail,int n)
        {
            string result = mail.Substring(mail.Length-n,n);
            Console.WriteLine(result);
            
        }
        static void GetUserName(string mail)
        {
            if (!mail.Contains('@'))
            {
                Console.WriteLine($"The email {mail} doesn't contain the @ symbol.");
            }
            else
            {
                int endIndex = mail.IndexOf('@');
                string result = mail.Substring(0,endIndex);
                Console.WriteLine(result);
            }
        }
        static void Replace(string mail,char c)
        {
            mail = mail.ToLower();
            
            string result = "";
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail[i]==c)
                {
                    result += '-';
                }
                else
                {
                    result += mail[i];
                }

            }
            Console.WriteLine(result);
        }
        static void Encrypt(string mail)
        {
            int[] result = new int[mail.Length];
            for (int i = 0; i < mail.Length; i++)
            {
                result[i] = (int)mail[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
