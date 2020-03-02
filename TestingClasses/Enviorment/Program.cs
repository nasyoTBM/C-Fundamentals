using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        
        int startTime = Environment.TickCount;
        
        Console.WriteLine(startTime);
        int seconds = startTime / 1000;
        int minutes = seconds / 60;
        int hours = minutes / 60;
        int days = hours / 24;
        Console.WriteLine($"Days: {days}, Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}.");
    }
}

