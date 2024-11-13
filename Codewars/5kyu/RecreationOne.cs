using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5kyu
{
    public class RecreationOne
    {
        //1, 246, 2, 123, 3, 82, 6, 41 are the divisors (dělitel) of number 246.
        //Squaring these divisors we get: 1, 60516(246*246), 4(2*2), 15129, 9, 6724, 36, 1681.
        //The sum of these squares is 84100 which is 290 * 290.

        //Find all integers between m and n (m and n integers with 1 <= m <= n) such that the sum of their squared divisors is itself a square.

        //We will return a string in a format of array of arrays
        //The subarrays (or tuples or Pairs) will have two elements:
        // -> first the number the squared divisors of which is a square and then the sum of the squared divisors.

        //list_squared(1, 250) --> "[[1, 1], [42, 2500], [246, 84100]]"
        //list_squared(42, 250) --> "[[42, 2500], [246, 84100]]"

        public static void Test()
        {
            var res = Run(1, 250);  //[[1, 1], [42, 2500], [246, 84100]]
        }

        public static string Run(long m, long n)
        {
            if (m > n) return "[]";

            List<long> divisors;
            List<(long,long)> results = new List<(long, long)>();
            long sum;

            for (long num = m; num <= n; num++)
            {
                divisors = new List<long>();

                //find all divisors
                for(long divisor = 1; divisor <= num; divisor++)
                {
                    //is x a divisor?
                    if(num % divisor == 0)
                    {
                        divisors.Add(divisor);
                    }
                }

                sum = divisors.Select(d => d * d).Sum();
                if (IsSquare(sum))
                {
                    results.Add((num, sum));
                }

            }

            if (results.Count() == 0) return "[]";

            string outString = "[";

            foreach(var res in results)
            {
                outString += $"[{res.Item1}, {res.Item2}], ";
            }

            outString = outString.Remove(outString.LastIndexOf(","));
            outString += "]";

            return outString;
        }

        private static bool IsSquare(long a)
        {
            long sqared = (long)Math.Sqrt(a);

            return sqared  * sqared == a;
        }
    }
}
