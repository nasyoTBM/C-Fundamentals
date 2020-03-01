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
        string[] names = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string action = Console.ReadLine();
        int blacklistedNamesCount = 0;
        int lostNamesCount = 0;
        while (action != "Report")
        {
            int index = int.MaxValue;
            string[] command = action.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (command[0] == "Blacklist")
            {
                BlacklistName(names, command[1]);

            }
            else if (command[0] == "Error")
            {
                index = int.Parse(command[1]);
                Error(names, index);


            }
            else if (command[0] == "Change")
            {
                index = int.Parse(command[1]);
                string newName = command[2];
                ChangeName(names, index, newName);
            }
            action = Console.ReadLine();
        }
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "Blacklisted")
            {
                blacklistedNamesCount++;
            }
            else if (names[i] == "Lost")
            {
                lostNamesCount++;
            }
        }
        Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
        Console.WriteLine($"Lost names: {lostNamesCount}");
        Console.WriteLine(string.Join(" ", names));

    }
    static string[] BlacklistName(string[] names, string name)
    {
        string[] result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            if (names.Contains(name))
            {
                if (names[i] == name)
                {

                    Console.WriteLine($"{names[i]} was blacklisted.");
                    names[i] = "Blacklisted";
                    result[i] = names[i];
                    break;

                }

            }
            else
            {
                Console.WriteLine($"{name} was not found.");
                break;
            }
            result[i] = names[i];
        }
        return result;

    }
    static string[] Error(string[] names, int index)
    {
        string[] result = new string[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            if (i == index)
            {
                if (names[i] != "Blacklisted" && names[i] != "Lost")
                {
                    Console.WriteLine($"{names[i]} was lost due to an error.");
                    names[i] = "Lost";
                }
            }
            result[i] = names[i];
        }
        return result;
    }
    static string[] ChangeName(string[] names, int index, string newName)
    {
        string[] result = new string[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            if (i == index)
            {
                Console.WriteLine($"{names[i]} changed his username to {newName}.");
                names[i] = newName;
            }
            result[i] = names[i];
        }
        return result;
    }
}
