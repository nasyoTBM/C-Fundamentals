using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        PasswordValidator(input);

    }
    static void PasswordValidator(string input)
    {
        if (!PasswordLength(input))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        if (!IsLetterOrDigit(input))
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!DigitCountChecker(input))
        {
            Console.WriteLine("Password must have at least 2 digits");
        }
        if (PasswordLength(input) && IsLetterOrDigit(input) && DigitCountChecker(input))
        {
            Console.WriteLine("Password is valid");
        }
    }
    static bool PasswordLength(string input)
    {
        bool isValid = true;

        if (input.Length < 6 || input.Length > 10)
        {

            isValid = false;

        }

        return isValid;
    }
    static bool IsLetterOrDigit(string input)
    {
        bool isLetterOrDiggit = false;

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

        }

        return isLetterOrDiggit;
    }
    static bool DigitCountChecker(string input)
    {
        bool isValid = false;
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                counter++;
            }
        }
        if (counter >= 2)
        {
            isValid = true;
        }

        return isValid;
    }

}

