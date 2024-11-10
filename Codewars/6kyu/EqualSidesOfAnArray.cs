using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._6kyu
{
    //You are going to be given an array of integers.
    //Your job is to take that array and find an index N where the sum of the integers to the left of N is equal
    //to the sum of the integers to the right of N.If there is no index that would make this happen, return -1.

    //Let's say you are given the array {1,2,3,4,3,2,1}:
    //Your function will return the index 3, because at the 3rd position of the array, the sum of left side of the index ({1,2,3})
    //and the sum of the right side of the index ({3,2,1}) both equal 6.

    public static class EqualSidesOfAnArray
    {
        //Version 3
        public static int FindEvenIndex3(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if(input.Take(i).Sum() == input.Skip(i + 1).Sum())
                {
                    return i;
                }
            }
            return -1;
        }

        //Version 2
        public static int FindEvenIndex2(int[] input)
        {
            int leftSum = 0;
            int rightSum = input.Sum();

            for(int i = 0; i < input.Length; i++)
            {
                rightSum -= input[i];

                if(leftSum == rightSum)
                {
                    return i;
                }

                leftSum += input[i];
            }

            return -1;
        }

        //Version 1
        public static int FindEvenIndex1(int[] input)
        {
            int leftSum = 0;
            int rightSum = 0;
            int index = 0;

            while (index < input.Length)
            {
                for (int i = 0; i < index; i++)
                {
                    leftSum += input[i];
                }
                for (int i = index + 1; i < input.Length; i++)
                {
                    rightSum += input[i];
                }
                if (leftSum == rightSum)
                {
                    return index;
                }
                leftSum = 0;
                rightSum = 0;
                index++;
            }
            return -1;
        }
    }
}
