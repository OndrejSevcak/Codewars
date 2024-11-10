using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6kyu
{
    //Given two arrays a and b write a function comp(a, b) that checks whether the two arrays have the "same" elements,
    //with the same multiplicities (the multiplicity of a member is the number of times it appears).
    //"Same" means, here, that the elements in b are the elements in a squared, regardless of the order.

    //Example:
    //a = [121, 144, 19, 161, 19, 144, 19, 11]  
    //b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]

    public static class AreTheyTheSame
    {
        //Version 3
        public static bool Comp3(int[] a, int[] b)
        {
            if(a == null || b == null) return false;

            int[] aSquared = a.Select(x => x * x).ToArray();
            Array.Sort(aSquared);
            Array.Sort(b);

            return aSquared.SequenceEqual(b);
        }

        //Version 2
        public static bool Comp2(int[] a, int[] b)
        {
            if (a is null || b is null) return false;
            if (a.Length != b.Length) return false;
            if (a.Length == 0 || b.Length == 0) return true;

            //get distinct numbers with their count as dictionary in both arrays
            var aDict = a.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            var bDict = b.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());

            //loop a and try to find its square in b
            foreach(var (num, count) in aDict)
            {
                int square = num * num;
                //does b contains square of a num and is the count same
                if(!bDict.TryGetValue(square, out int bCount) || bCount != count)
                {
                    return false;
                }
            }
            return true;
        }

        //Version 1
        public static bool Comp1(int[] a, int[] b)
        {
            if (a is null || b is null) return false;
            if (a.Length != b.Length) return false;
            if (a.Length == 0 || b.Length == 0) return true;

            //loop numbers in a
            for (int i = 0; i < a.Length; i++)
            {
                //if number exists multiple times
                if (a.Count(n => n == a[i]) > 1)
                {
                    //count sqaures of specific number exists in b
                    int countSquare = b.Where(b => b == Math.Pow(a[i], 2)).Count();
                    //count how many times the specific number exists in a
                    int countNumber = a.Where(n => n == a[i]).Count();

                    if (countSquare != countNumber) return false;
                }
                else
                {
                    if (!b.Any(b => b == Math.Pow(a[i], 2)))
                    {
                        return false;
                    }
                }
            }
            //loop numbers in b
            for (int i = 0; i < b.Length; i++)
            {
                //does number exists multiple times
                if (b.Count(num => num == b[i]) > 1)
                {
                    int countSqrts = a.Where(num => num == Math.Sqrt(b[i])).Count();
                    int nums = b.Where(num => num == b[i]).Count();

                    if (countSqrts != nums) return false;
                }
                else
                {
                    if (!a.Any(num => num == Math.Sqrt(b[i])))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
