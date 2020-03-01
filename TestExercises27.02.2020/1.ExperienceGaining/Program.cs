using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double neededExpirience = double.Parse(Console.ReadLine());
        int battlesCount = int.Parse(Console.ReadLine());
        double container = 0;
        int battlesCounter = 0;
        for (int i = 1; i <= battlesCount; i++)
        {
            battlesCounter++;
            double experienceGained = double.Parse(Console.ReadLine());
            container += experienceGained;
            if (i % 3 == 0)
            {
                container += experienceGained * 0.15;
            }
            if (i % 5 == 0)
            {
                container -= experienceGained * 0.10;
            }

            if (container >= neededExpirience)
            {

                break;
            }

        }
        if (container >= neededExpirience)
        {


            Console.WriteLine($"Player successfully collected his needed experience for {battlesCounter} battles.");
        }
        else
        {
            Console.WriteLine($"Player was not able to collect the needed experience, {neededExpirience - container:F2} more needed.");
        }
    }
}

