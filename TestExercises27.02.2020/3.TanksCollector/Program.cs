using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        List<string> tanks = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            int index = int.MaxValue;
            string tankName = string.Empty;
            string[] command = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (command[0] == "Add")
            {

                AddTank(tanks, command[1]);

            }

            else if (command[0] == "Remove")
            {

                RemoveTank(tanks, command[1]);

            }

            else if (command[0] == "Remove At")
            {
                index = int.Parse(command[1]);
                RemoveAtTank(tanks, index);

            }

            else if (command[0] == "Insert")
            {
                index = int.Parse(command[1]);
                tankName = command[2];
                InsertTank(tanks, index, tankName);

            }

        }

        Console.WriteLine(string.Join(", ", tanks));
    }
    static void AddTank(List<string> tanks, string tankName)
    {

        if (tanks.Contains(tankName))
        {
            Console.WriteLine("Tank is already bought");
        }
        else
        {
            Console.WriteLine("Tank successfully bought");
            tanks.Add(tankName);
        }


    }
    static void RemoveTank(List<string> tanks, string tankName)
    {

        if (tanks.Contains(tankName))
        {
            Console.WriteLine("Tank successfully sold");
            tanks.Remove(tankName);
        }
        else
        {
            Console.WriteLine("Tank not found");
        }

    }
    static void RemoveAtTank(List<string> tanks, int index)
    {

        if (tanks.Count == 0 && index == 0)
        {
            Console.WriteLine("Index out of range");
        }

        for (int i = 0; i < tanks.Count; i++)
        {
            if (i == index)
            {
                Console.WriteLine("Tank successfully sold");
                tanks.RemoveAt(index);
                break;
            }

            else if (index < 0 || index > tanks.Count - 1)
            {
                Console.WriteLine("Index out of range");
                break;
            }
        }

    }
    static void InsertTank(List<string> tanks, int index, string tankName)
    {

        for (int i = 0; i < tanks.Count; i++)
        {

            if (index < 0 || index > tanks.Count-1)
            {
                Console.WriteLine("Index out of range");
                break;
            }

            if (tanks.Contains(tankName))
            {
                Console.WriteLine("Tank is already bought");
                break;
            }

            else
            {
                Console.WriteLine("Tank successfully bought");
                tanks.Insert(index, tankName);
                break;
            }
        }

    }
}


