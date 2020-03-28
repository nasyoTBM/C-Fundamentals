using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine().ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder sb = new StringBuilder();
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {

                int singleNumber = int.Parse(firstNum[i].ToString());
                int sum = (singleNumber * multiplier) + reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;

            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }
            List<char> result = sb.ToString().Reverse().ToList();
            RemoveTrailingZeros(result);
            Console.WriteLine(string.Join("", result));


        }
        private static void RemoveTrailingZeros(List<char> result)
        {
            if (result[0] == '0')
            {
                int end = 0;
                for (int i = 1; i < result.Count; i++)
                {
                    if (result[i] != '0')
                    {
                        end = i;
                    }
                }
                for (int i = 0; i < end; i++)
                {
                    result.RemoveAt(0);
                }
            }


        }

    }
}
