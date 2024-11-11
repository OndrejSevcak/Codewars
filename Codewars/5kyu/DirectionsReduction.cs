using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5kyu
{
    //a man was given directions to go from one point to another.
    //The directions were "NORTH", "SOUTH", "WEST", "EAST". Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too.

    //You can immediately see that going "NORTH" and immediately "SOUTH" is not reasonable, better stay to the same place!
    //So the task is to give to the man a simplified version of the plan. A better plan in this case is simply:
    //[WEST]

    public class DirectionsReduction
    {
        //Version 3 - using dictionary, list and foreach
        public static string[] Run3(string[] directions)
        {
            Dictionary<string, string> oppositeDirections = new Dictionary<string, string>()
            {
                {"NORTH", "SOUTH" },
                {"SOUTH", "NORTH" },
                {"EAST", "WEST" },
                {"WEST", "EAST" }
            };

            List<string> result = new List<string>();

            foreach (string direction in directions)
            {
                if(result.LastOrDefault() == oppositeDirections[direction])
                {
                    result.RemoveAt(result.Count() - 1);
                }
                else
                {
                    result.Add(direction);
                }
            }

            return result.ToArray();
        }


        //Version 2 - using stack, foreach and switch
        public static string[] Run2(string[] directions)
        {
            Stack<string> stack = new Stack<string>();

            foreach (string direction in directions)
            {
                string? topElement = stack.Count() > 0 ? stack.Peek().ToString() : null;

                switch (direction)
                {
                    case "NORTH": if ("SOUTH" == topElement) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "SOUTH": if ("NORTH" == topElement) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "EAST": if ("WEST" == topElement) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "WEST": if ("EAST" == topElement) { stack.Pop(); } else { stack.Push(direction); } break;
                }  
            };

            var result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }


        //Version 1 - using while and for loop 
        public static string[] Run1(string[] directions)
        {

            bool loop = true;
            List<string> _directions = directions.ToList();

            while (loop)
            {
                for (int i = 0; i < _directions.Count; i++)
                {
                    if (i + 1 < _directions.Count)
                    {
                        if (_directions[i] == "NORTH" && _directions[i + 1] == "SOUTH" ||
                            _directions[i] == "SOUTH" && _directions[i + 1] == "NORTH" ||
                            _directions[i] == "EAST" && _directions[i + 1] == "WEST" ||
                            _directions[i] == "WEST" && _directions[i + 1] == "EAST")
                        {
                            _directions.RemoveAt(i);
                            _directions.RemoveAt(i);    //there is one element less after removing the first one
                            break;
                        }
                    }
                    else
                    {
                        loop = false;
                    }
                }
                //Does a combination exists?
                loop = OppositeDirectionExists(_directions.ToArray());
            }

            return _directions.ToArray();
        }

        public static bool OppositeDirectionExists(string[] directions)
        {
            for (int i = 0; i < directions.Length; i++)
            {
                if (i + 1 < directions.Length)
                {
                    if (directions[i] == "NORTH" && directions[i + 1] == "SOUTH" ||
                        directions[i] == "SOUTH" && directions[i + 1] == "NORTH" ||
                        directions[i] == "EAST" && directions[i + 1] == "WEST" ||
                        directions[i] == "WEST" && directions[i + 1] == "EAST")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
