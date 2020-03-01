using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] neighborhood = Console.ReadLine().Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        string input = Console.ReadLine();
        int successfullPlaces = 0;
        int failedPlaces = 0;
        int startIndex = 0;

        while (input != "Love!")
        {
            String[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int jumpLength = int.Parse(command[1]);

            for (int i = startIndex; i < neighborhood.Length; i++)
            {
                if (jumpLength > neighborhood.Length - 1 || startIndex + jumpLength > neighborhood.Length - 1)
                {
                    startIndex = 0;

                    if (neighborhood[0] > 0)
                    {
                        neighborhood[0] -= 2;

                        if (neighborhood[0] == 0)
                        {
                            Console.WriteLine($"Place 0 has Valentine's day.");
                            break;

                        }

                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Place 0 already had Valentine's day.");
                        break;
                    }

                }

                else
                {
                    startIndex = jumpLength + i;

                    if (neighborhood[startIndex] > 0)
                    {
                        neighborhood[startIndex] -= 2;

                        if (neighborhood[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {jumpLength + i} has Valentine's day.");
                            break;
                        }

                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Place {jumpLength + i} already had Valentine's day.");
                        break;
                    }
                }
            }

            input = Console.ReadLine();

        }

        Console.WriteLine($"Cupid's last position was {startIndex}.");

        for (int i = 0; i < neighborhood.Length; i++)
        {
            if (neighborhood[i] == 0)
            {
                successfullPlaces++;
            }
        }

        failedPlaces = neighborhood.Length - successfullPlaces;

        if (failedPlaces == 0)
        {
            Console.WriteLine("Mission was successful.");
        }
        else
        {
            Console.WriteLine($"Cupid has failed {failedPlaces} places.");

        }
    }
}

