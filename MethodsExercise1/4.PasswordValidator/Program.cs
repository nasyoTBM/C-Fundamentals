using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //TERRIBLE APPROACH AND TERRIBLE SOLUTION,SOMEHOW WORKING....
        //AVOID THIS BAD PRACTICE!!!

        string input = Console.ReadLine();
        PasswordValidator(input);

    }
    static void PasswordValidator(string input)
    {
        bool isValid = true;
        int digitCounter = 0;
        bool isLetterOrDiggit = true;
        if (input.Length < 6 || input.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;

        }
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetterOrDigit(input[i]))
            {
                isLetterOrDiggit = true;
            }
            else
            {

                isLetterOrDiggit = false;
                break;


            }
            if (char.IsDigit(input[i]))
            {
                digitCounter++;
            }

        }
        if (!isLetterOrDiggit)
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;

        }
        if (digitCounter < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;

        }

        if (isValid)
        {

            Console.WriteLine("Password is valid");
        }
    }
}

