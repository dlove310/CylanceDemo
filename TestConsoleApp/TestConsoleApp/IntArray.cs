using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    public class IntArray

    {
        public static List<string> NumberToString(string[] replacement, int[] divisableBy)
        {
            var outputArray = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % divisableBy[0] == 0)
                {
                    outputArray.Add(replacement[0]);
                }
                if (i % divisableBy[1] == 0)
                {
                    outputArray.Add(replacement[1]);
                }
                if (i % divisableBy[0] != 0 & i % divisableBy[1] != 0)
                {
                    outputArray.Add(i.ToString());
                }
            }
            return outputArray;
        }
    }
}
    

