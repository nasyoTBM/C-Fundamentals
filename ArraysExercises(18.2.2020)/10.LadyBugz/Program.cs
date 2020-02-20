using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] BugsIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] populatedField = new int[fieldSize];
        for (int i = 0; i < populatedField.Length; i++)
        {
            for (int j = 0; j < BugsIndexes.Length; j++)
            {
                if (BugsIndexes[j] == i)
                {
                    populatedField[i] = 1;
                }
            }

        }


        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] command = input.Split(new char[] { ' ' }).ToArray();
            int ladyBugIndex = int.Parse(command[0]);
            string direction = command[1];
            int flyLength = int.Parse(command[2]);
            if (ladyBugIndex < 0 || ladyBugIndex > fieldSize - 1)
            {
                input = Console.ReadLine();
                continue;
            }
            if (flyLength < 0)
            {
                SwitchDirections(ref direction);
            }
            if (direction == "right")
            {
                MoveRight(populatedField, ladyBugIndex, flyLength);
            }
            else if (direction == "left")
            {
                MoveLeft(populatedField, ladyBugIndex, flyLength);
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", populatedField));
    }

    static string SwitchDirections(ref string direction)
    {
        if (direction == "right")
        {
            direction = "left";
        }
        else if (direction == "left")
        {
            direction = "right";
        }
        return direction;
    }
    static int[] MoveRight(int[] populated, int index, int flyLength)
    {
        flyLength = Math.Abs(flyLength);

        for (int i = 0; i < populated.Length; i++)
        {
            if (flyLength == 0)
            {
                //populated[index] = 0;
                return populated;
            }
            if (index + flyLength > populated.Length - 1)
            {
                populated[index] = 0;
                return populated;
            }
            if (populated[index] == i && populated[index] == 1)
            {
                if (populated[index + flyLength] == 1)
                {
                    flyLength += flyLength;
                    i--;
                }
                else
                {
                    populated[index + flyLength] = 1;
                    populated[index] = 0;
                }
            }

        }
        return populated;
    }
    static int[] MoveLeft(int[] populated, int index, int flyLength)
    {
        flyLength = Math.Abs(flyLength);
        for (int i = populated.Length - 1; i >= 0; i--)
        {
            if (flyLength == 0)
            {
                //populated[index] = 0;
                return populated;
            }
            if (index - flyLength < 0)
            {
                populated[index] = 0;
                return populated;
            }
            if (populated[index] == i && populated[index] == 1)
            {
                if (populated[index - flyLength] == 1)
                {
                    flyLength += flyLength;
                    i++;
                }
                else
                {
                    populated[index - flyLength] = 1;
                    populated[index] = 0;
                }
            }
        }
        return populated;
    }
}

