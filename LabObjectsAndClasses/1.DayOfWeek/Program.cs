using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        //string[] inputDate = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //DateTime result = new DateTime(year: int.Parse(inputDate[2]), month: int.Parse(inputDate[1]), day: int.Parse(inputDate[0]));
        //Console.WriteLine(result.DayOfWeek);
        string input = Console.ReadLine();
        DateTime result = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(result.DayOfWeek);





    }
}
