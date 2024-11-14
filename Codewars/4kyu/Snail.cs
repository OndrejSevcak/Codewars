using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4kyu
{
    public class Snail
    {
        public static int[] Run(int[][] array)
        {
            List<int> result = new List<int>();

            if (array == null || array.Length == 0) return new int[0];

            int top = 0;                      // Starting row
            int bottom = array.Length - 1;    // Ending row
            int left = 0;                      // Starting column
            int right = array[0].Length - 1;  // Ending column

            while (top <= bottom && left <= right)
            {
                //top row
                for (int i = left; i <= right; i++)
                {
                    result.Add(array[top][i]);
                }
                top++; // Move the top boundary down

                //right column top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(array[i][right]);
                }
                right--; // Move the right boundary left

                //bottom row right to left if possible
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(array[bottom][i]);
                    }
                    bottom--; // Move the bottom boundary up
                }

                //left column bottom to top if possible
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(array[i][left]);
                    }
                    left++; // Move the left boundary right
                }
            }

            return result.ToArray();
        }
    }
}
